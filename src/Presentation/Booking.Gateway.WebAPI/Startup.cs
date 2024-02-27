//#define dds_tests

using Booking.Gateway.Application;
using MassTransit;
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
#if dds_tests
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(Configuration["RabbitMQdds:Host"], h =>
                {
                    h.Username(Configuration["RabbitMQdds:Username"]);
                    h.Password(Configuration["RabbitMQdds:Password"]);
                });
            });

#else
            // Добавляем шину сообщений
            x.UsingRabbitMq((context, cfg) =>
            {
                cfg.Host(Configuration["RabbitMQ:Host"], h =>
                {
                    h.Username(Configuration["RabbitMQ:Username"]);
                    h.Password(Configuration["RabbitMQ:Password"]);
                });
            });
#endif
        });
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });           
            c.ExampleFilters();
        });
        services.AddSwaggerExamplesFromAssemblyOf<Startup>(); 
        services.AddMvc();
        
        services.AddControllers();
    }
    
    public void Configure(WebApplication app, IWebHostEnvironment env) 
    {
        app.MapControllers();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthorization();
        
        // Enable middleware to serve generated Swagger as a JSON endpoint.
        app.UseSwagger();
        // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
        // specifying the Swagger JSON endpoint.
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
        
        app.Run();
        
    }
}