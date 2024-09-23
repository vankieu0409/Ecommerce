
using Ecommerce.Client.Services.Authentications;
using Ecommerce.Client.Services.CartService;
using Ecommerce.Client.Services.CategoryService;
using Ecommerce.Client.Services.OrderService;
using Ecommerce.Client.Services.ProductService;

using Microsoft.AspNetCore.Components.Authorization;

using System.Reflection;
using Ecommerce.Client.Authentication;

namespace Ecommerce.Client.Extensions.DependencyInjection;

public static class ServiceCollection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();
        var entryAssembly = Assembly.GetEntryAssembly();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddTransient<ICartService, CartService>();
        services.AddTransient<ICategoryService, CategoryService>();
        services.AddTransient<IOrderService, OrderService>();
        services.AddTransient<IProductService, ProductService>();
        //services.AddSingleton<IJSRuntime>(provider => provider.GetRequiredService<IJSRuntime>());
        services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

        return services;
    }
}