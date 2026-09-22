using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://hogwartswebapi-emfgduhhb5cpbeck.centralus-01.azurewebsites.net/api/Estudiantes")
});

await builder.Build().RunAsync();