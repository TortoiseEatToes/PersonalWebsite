using Microsoft.FluentUI.AspNetCore.Components;
using PersonalWebsite.Components;

var app = BuildRazorApp(args);
RunApplication(app);

static WebApplication BuildRazorApp(string[] args)
{
    var builder = WebApplication.CreateBuilder(args);
    builder.Services.AddRazorComponents();
    builder.Services.AddFluentUIComponents();
    return builder.Build();
}

static void RunApplication(WebApplication application)
{
    // Configure the HTTP request pipeline.
    if (!application.Environment.IsDevelopment())
    {
        application.UseExceptionHandler("/Error", createScopeForErrors: true);
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        application.UseHsts();
    }

    application.UseHttpsRedirection();
    application.UseAntiforgery();
    application.MapStaticAssets();
    application.MapRazorComponents<App>();
    application.Run();
}