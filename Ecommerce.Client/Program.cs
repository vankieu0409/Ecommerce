using Blazored.LocalStorage;

using Ecommerce.Client;
using Ecommerce.Client.Services.Common;
using Ecommerce.Client.Services.ProductService;

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");


builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddBlazoredLocalStorage();
builder.Services.AddMudServices();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ICommonService, CommonService>();


await builder.Build().RunAsync();
