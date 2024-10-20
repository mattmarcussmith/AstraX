using AstraX.Ui;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzUzOTAzNkAzMjM3MmUzMDJlMzBqSzErR0U4OGxQZENRZnRwaFYyU3hyV2MvQm1Rek02TUY2ajFnaXFYditrPQ==");

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();