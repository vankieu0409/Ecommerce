using System.Reflection;
using System.Text;

using Ecommerce.Application.Interfaces.IRepositories;
using Ecommerce.Application.Interfaces.IServices;
using Ecommerce.Application.Interfaces.IUnitOfWork;
using Ecommerce.Application.Services;
using Ecommerce.Infrastructure.Logging;
using Ecommerce.Infrastructure.Persistence.DBContext;
using Ecommerce.Infrastructure.Persistence.Repositories;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;

using Serilog;

namespace Ecommerce.Infrastructure.Extension;

public static class ServiceCollection
{
    /// <summary>
    ///  nơi viết các dependence injection cho các service
    /// </summary>
    /// <param name="services"></param>
    /// <returns></returns>
    public static IServiceCollection ConfigureServices(this IServiceCollection services) =>
        services.AddScoped<IProductRepository, ProductRepository>()
            .AddScoped<ICustomerRepository, CustomerRepository>()
            .AddScoped<IAddressOfCustomerRepository, AddressOfCustomerRepository>()
            .AddScoped<IOrderRepository, OrderRepository>()
            .AddScoped<IOrderDetailRepository, OrderDetailRepository>()
            .AddScoped<IRoleRepository, RoleRepository>()
            .AddScoped<IVariantRepository, VariantRepository>()
            .AddScoped<IEmployeeRepository, EmployeeRepository>()
            .AddTransient<IUnitOfWork, UnitOfWork.UnitOfWork>()
            .AddTransient<IOrderService, OrderService>()
            .AddTransient<IProductService, ProductService>();



    public static IServiceCollection ConfigureLogging(this IServiceCollection services) =>
        services.AddSerilog(logbuilder =>
                logbuilder.Enrich.FromLogContext()
                          .Enrich.WithMachineName()
                          .WriteTo.Console()
                          .WriteTo.Debug()
                          .MinimumLevel.Debug())
            .AddTransient<LoggingDelegatingHandler>();



    public static IServiceCollection AddConfigurationSettings(this IServiceCollection services, ConfigurationManager configuration)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        var entryAssembly = Assembly.GetEntryAssembly();

        services.AddCors();
        services.AddAutoMapper(configuration => { }, executingAssembly,
            entryAssembly);


        services.AddAuthentication(
            options => //được sử dụng để cấu hình xác thực trong ứng dụng và thiết lập chế độ xác thực và thách thức mặc định cho JWT bearer authentication.
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }
        ).AddJwtBearer(options =>
        {
            options.SaveToken =
                true; //Một giá trị boolean xác định liệu có nên lưu token nhận được trong vé xác thực vào AuthenticationProperties sau khi xác thực thành công hay không.
                      //options.RequireHttpsMetadata = false; // Một giá trị boolean xác định liệu middleware có yêu cầu HTTPS để truy cập điểm cuối xác thực hay không.
            options.TokenValidationParameters =
                new TokenValidationParameters() //xác định các tham số được sử dụng để xác thực token JWT
                {
                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = false, // Một giá trị boolean xác định liệu nên xác thực nhà cung cấp token (issuer) hay không.
                    ValidateAudience = false, // Một giá trị boolean xác định liệu nên xác thực khán giả (audience) của token hay không.
                    ValidAudience = configuration["Authentication:Jwt:ValidAudience"], //Một chuỗi giá trị xác định khán giả hợp lệ cho token.
                    ValidIssuer = configuration["Authentication:Jwt:ValidIssuer"], // Một chuỗi giá trị xác định nhà cung cấp token hợp lệ cho token.
                    IssuerSigningKey =
                        new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Authentication:Jwt:Secret"])), //Một đối tượng SymmetricSecurityKey chứa khóa bí mật được sử dụng để ký token.
                    RequireExpirationTime = false, // Một giá trị boolean xác định liệu nên yêu cầu token có thời gian hết hạn hay không.

                };
            options.Events = new JwtBearerEvents
            {
                OnAuthenticationFailed = context =>
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("\n OnAuthenticationFailed: " + context.Exception.Message + '\n');
                    Console.ResetColor();
                    return Task.CompletedTask;
                },
                OnTokenValidated = context =>
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n OnTokenValidated: " + context.SecurityToken + '\n');
                    Console.ResetColor();
                    return Task.CompletedTask;
                },

                OnForbidden = context =>
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("\n OnForbidden: " + context.Result + '\n');
                    Console.ResetColor();
                    return Task.CompletedTask;
                },

                OnChallenge = context =>
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n OnChallenge: " + context.AuthenticateFailure + '\n');
                    Console.ResetColor();
                    return Task.CompletedTask;
                },
                OnMessageReceived = context =>
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n OnMessageReceived: " + context.Request.Headers.Authorization + '\n');
                    Console.ResetColor();
                    return Task.CompletedTask;
                }
            };
        });
        services.AddAuthorization();

        services.AddDbContext<ApplicationDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("SQLConnection")).LogTo(Console.WriteLine).EnableSensitiveDataLogging());
        services.AddHttpContextAccessor();

        return services;

    }

}