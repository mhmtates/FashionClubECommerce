using FashionClubECommerce.Business;
using FashionClubECommerce.Business.AutoMapper.Profiles;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews().AddFluentValidation();
builder.Services.AddBusinessServices();
builder.Services.AddAutoMapper(typeof(AllProfile));

// Kontrol sonrasý nasýl iþlem yapýlacaðýný belirten kod bloðum.
builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x => {
        x.LoginPath = "/Login";
        x.ExpireTimeSpan = TimeSpan.FromHours(1);
        x.AccessDeniedPath = "/Denied";
    });
// Butün Controller'da kontrolü Yapan Yapýmýzdýr.
builder.Services.AddControllersWithViews(x => {
    var dogrulama = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
    x.Filters.Add(new AuthorizeFilter(dogrulama));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();