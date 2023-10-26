using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Internal;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace YourNamespace
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method is used to configure and register services.
        public void ConfigureServices(IServiceCollection services)
        {
            object value = services.AddControllers(); // Add support for MVC controllers
            // Add other services here
        }

        // This method is used to configure the request processing pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); // Enable developer-friendly error pages
            }
            else
            {
                app.UseExceptionHandler("/Home/Error"); // Configure error handling for non-development environments
                app.UseHsts(); // Enable HTTP Strict Transport Security
            }

            app.UseHttpsRedirection(); // Redirect HTTP to HTTPS
            app.UseStaticFiles(); // Serve static files from wwwroot
            app.UseRouting(); // Configure routing

            app.UseAuthorization(); // Configure authorization

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });

            // Add additional middleware components here
        }
    }

    public interface IWebHostEnvironment
    {
    }
}
