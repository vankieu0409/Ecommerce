using Ecommerce.Infrastructure.Extension;

using Serilog;

var builder = WebApplication.CreateBuilder(args);
Log.Information($"Start {builder.Environment.ApplicationName} up");

try
{

    // Add services to the container.

    builder.Services.AddControllersWithViews();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

    builder.Services.ConfigureLogging();
    builder.Services.AddRazorPages();
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddServerSideBlazor();
    builder.Services.AddRazorPages();
    builder.Services.AddConfigurationSettings(builder.Configuration);
    builder.Services.ConfigureServices();
    builder.Services.AddHealthChecks();
    var app = builder.Build();
    app.UseSerilogRequestLogging();
    //app.UseSwaggerUI();
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseWebAssemblyDebugging();
    }
    else
    {
        app.UseExceptionHandler("/Error");
        app.UseHsts();
    }

    app.UseRouting();
    app.UseHttpsRedirection();
    app.UseBlazorFrameworkFiles();
    app.UseHealthChecks("/health");
    app.UseAuthorization();


    app.UseStaticFiles();


    app.MapRazorPages();
    app.MapControllers();
    app.MapBlazorHub();
    app.MapFallbackToFile("index.html");

    app.Run();
}

catch (Exception ex)
{
    string type = ex.GetType().Name;
    if (type.Equals("StopTheHostException", StringComparison.Ordinal)) throw;

    Log.Fatal(ex, $"Unhandled exception: {ex.Message}");
}
finally
{
    Log.Information($"Shutdown {builder.Environment.ApplicationName} complete");
    Log.CloseAndFlush();
}

