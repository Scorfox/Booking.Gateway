using Microsoft.OpenApi.Models;

namespace Booking.WebAPI;

public class Startup 
{
    public IConfiguration configRoot { get; }
    
    public Startup(IConfiguration configuration) 
    {
        configRoot = configuration;
    }
    
    public void ConfigureServices(IServiceCollection services) 
    {
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });                
        });
        services.AddControllers();
    }
    
    public void Configure(WebApplication app, IWebHostEnvironment env) 
    {
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