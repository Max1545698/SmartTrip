using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

using EasyNetQ;

using SmartTrip.DAL;
using SmartTrip.DAL.Core;
using SmartTrip.DAL.EF;


namespace SmartTrip.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration config)
        {
            Configuration = config;
        }

        public void ConfigureDevelopmentServices(IServiceCollection services)
        {
            ConfigureProductionServices(services);
        }
    
        public void ConfigureProductionServices(IServiceCollection services)
        {
            try
            {
                services.AddDbContext<ApplicationContext>(context =>
                {
                    context.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]);
                });
            }
            catch (Exception ex)
            {
                var message = ex.Message;
            }
            ConfigureServices(services);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddTransient((s) => RabbitHutch.CreateBus("host=localhost"));
            services.AddMemoryCache();
            services.AddMvc();

        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/Error");
            }

            app.UseAuthentication();
            app.UseStaticFiles();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
