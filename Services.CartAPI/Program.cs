using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Service.MessageBus;
using Services.CartAPI;
using Services.CartAPI.Data;
using Services.CartAPI.Extensions;
using Services.CartAPI.Service;
using Services.CartAPI.Service.IService;
using Services.CartAPI.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<AppDbContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

IMapper mapper = MappingConfig.RegisterMaps().CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

builder.Services.AddHttpContextAccessor();
builder.Services.AddScoped<BackendApiAuthenticationHttpClientHandler>();

builder.Services.AddHttpClient("Product", u => u.BaseAddress =
new Uri(builder.Configuration["ServiceUrls:ProductAPI"])).AddHttpMessageHandler<BackendApiAuthenticationHttpClientHandler>();

builder.Services.AddHttpClient("Coupon", u => u.BaseAddress =
new Uri(builder.Configuration["ServiceUrls:CouponAPI"])).AddHttpMessageHandler<BackendApiAuthenticationHttpClientHandler>();

builder.Services.AddScoped<ICouponService, CouponService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IMessageBus, MessageBus>();

builder.Services.AddHttpContextAccessor();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(option =>
{
    option.AddSecurityDefinition(name: JwtBearerDefaults.AuthenticationScheme, securityScheme: new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter the Bearer Authorization string as following: `Bearer Generated-JWT-Token`",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer"
    });
    option.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference= new OpenApiReference
                {
                    Type=ReferenceType.SecurityScheme,
                    Id=JwtBearerDefaults.AuthenticationScheme
                }
            }, new string[]{}
        }
    });
});

builder.AddAppAuthetication();

builder.Services.AddAuthorization();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI(c =>
{
    if (!app.Environment.IsDevelopment())
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Product API");
        c.RoutePrefix = string.Empty;
    }
});

Stripe.StripeConfiguration.ApiKey = builder.Configuration.GetSection("Stripe:SecretKey").Get<string>();

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();