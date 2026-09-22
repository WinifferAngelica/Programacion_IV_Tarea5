using BlazorClient.Client.Pages;
using BlazorClient.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

// Registrar HttpClient para el proyecto BlazorClient
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://hogwartswebapi-emfgduhhb5cpbeck.centralus-01.azurewebsites.net/api/Estudiantes")
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute(
    "/not-found",
    createScopeForStatusCodePages: true);

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(
        typeof(BlazorClient.Client._Imports).Assembly);

app.Run();