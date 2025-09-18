using FleetManager.Data;
using fs_a_2025_blazor_0918_78045.Repositories;
using fs_a_2025_blazor_0918_78045.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddScoped<CarRepository>();
// Add services to the container.  
builder.Services.AddRazorComponents()
   .AddInteractiveServerComponents();

builder.Services.AddRazorComponents();
builder.Services.AddScoped<CarRepository>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();