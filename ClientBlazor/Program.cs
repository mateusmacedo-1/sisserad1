using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ClientBlazor;
using MudBlazor.Services;


var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddHttpClient("ApiSerad", client =>
{
    // client.BaseAddress = new Uri("https://sisserad-api.onrender.com");
    //  client.BaseAddress = new Uri("http://localhost:8080");
    client.BaseAddress = new Uri("https://seradapi-2a3iml76ea-rj.a.run.app");
});
builder.Services.AddHttpClient("ApiCepBrasilAberto", client =>
{
    client.BaseAddress = new Uri("https://api.brasilaberto.com/");
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
await builder.Build().RunAsync();
