using Desafio.RedService.Presentation.Blazor.Site;
using Desafio.RedService.Presentation.Blazor.Site;
using Desafio.RedService.Presentation.Blazor.Site.Extensions.ViaCep;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddViaCep();

await builder.Build().RunAsync();
