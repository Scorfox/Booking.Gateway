//#define dds_tests

using System.Text;
using Booking.Gateway.Application;
using Booking.WebAPI.Extensions;
using MassTransit;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;

namespace Booking.WebAPI;

public class Startup 
{
    public IConfiguration Configuration { get; }
    
    public Startup(IConfiguration configuration) 
    {
        Configuration = configuration;
    }
    
    public void ConfigureServices(IServiceCollection services)
    {
        services.ConfigureApplication();
        services.AddMassTransit(x =>
        {
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(Configuration["RabbitMQ:Host"], h =>
                {
                    h.Username(Configuration["RabbitMQ:Username"]);
                    h.Password(Configuration["RabbitMQ:Password"]);
                });
            });
        });
           
        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Test API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type=ReferenceType.SecurityScheme,
                            Id="Bearer"
                        }
                    },
                    new string[]{}
                }
            });
        });

        services.AddCors(options =>
        {
            options.AddPolicy(name: "CorsApi",
                builder =>
                {
                    var origins = Configuration["AllowedOrigins"]!.Split(";");
                    builder.WithOrigins(origins)
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });

        services.AddSwaggerExamplesFromAssemblyOf<Startup>(); 
            
        services.AddMvc();
        
        services.AddControllers();
        
        var validIssuer = Configuration.GetValue<string>("Jwt:Issuer");
        var validAudience = Configuration.GetValue<string>("Jwt:Audience");
        var symmetricSecurityKey = Configuration.GetValue<string>("Jwt:SecretKey");

        services.AddAuthentication(options => {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;})
            .AddJwtBearer(options =>
            {
                options.IncludeErrorDetails = true;
                options.TokenValidationParameters = new TokenValidationParameters()
                {
                    ClockSkew = TimeSpan.Zero,
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = validIssuer,
                    ValidAudience = validAudience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(symmetricSecurityKey)
                    ),
                };
            });
    }
    
    public void Configure(WebApplication app, IWebHostEnvironment env) 
    {
        app.MapControllers();
        app.UseErrorHandler();
        app.UseStaticFiles();
        app.UseHttpsRedirection();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseCors("CorsApi");
        
        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();
        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
        // specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
    }
}