using FashionClubECommerce.Business;
using FashionClubECommerce.Business.AutoMapper.Profiles;
using FashionClubECommerce.WebAPI.JwtAuthorizeToken.Abstract;
using FashionClubECommerce.WebAPI.JwtAuthorizeToken.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(x =>
            x.AddPolicy("CorsPolicy", c => c.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));
builder.Services.AddBusinessServices();
builder.Services.AddAutoMapper(typeof(AllProfile));
string SecurityKey = builder.Configuration["Token:SecurityKey"];
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    x.RequireHttpsMetadata = false;
    x.SaveToken = true;
    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateAudience = false, // Herkes Kullanabilir.
        ValidAudience = builder.Configuration["Token:Audience"], // Kullanacak Adresler.
        ValidateIssuer = false, // Daðýtým Yapan Bilgisi Açýk.
        ValidIssuer = builder.Configuration["Token:Issuer"], // Daðýtým Yapan.
        ValidateIssuerSigningKey = true, // Çözmek için Güvenlik Anahtarý var
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SecurityKey))
    };
});
builder.Services.AddScoped<IAuthService, AuthManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("CorsPolicy");

app.UseRouting();

app.Run();
