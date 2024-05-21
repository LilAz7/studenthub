using Components;
using Microsoft.EntityFrameworkCore;
using Module;
using PKS5._5.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

builder.Services.AddDbContext<Pks5Context>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("default"));
});



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
