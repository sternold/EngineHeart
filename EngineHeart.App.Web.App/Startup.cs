using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using EngineHeart.App.Web.App.Components;
using EngineHeart.App.Web.App.Services;

namespace EngineHeart.App.Web.App
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddMvc()
                .AddNewtonsoftJson();

            services
                .AddRazorComponents()
                .AddSingleton<WeatherForecastService>();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();
            else
                app.UseHsts();

            app
                .UseHttpsRedirection()
                .UseStaticFiles()
                .UseRouting(routes =>
            {
                routes.MapRazorPages();
                routes.MapComponentHub<WebApp>("app");
            });
        }
    }
}
