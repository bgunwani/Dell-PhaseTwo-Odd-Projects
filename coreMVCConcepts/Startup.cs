using coreMVCConcepts.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreMVCConcepts
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.Add(new ServiceDescriptor(typeof(IEmployeeRepository), 
                new EmployeeRepository())); // By Default Singleton IOC

            /*
            services.Add(new ServiceDescriptor(typeof(IEmployeeRepository),
                typeof(EmployeeRepository), ServiceLifetime.Singleton));    // Singleton
            services.Add(new ServiceDescriptor(typeof(IEmployeeRepository),
                typeof(EmployeeRepository), ServiceLifetime.Transient));    // Transient
            services.Add(new ServiceDescriptor(typeof(IEmployeeRepository),
                typeof(EmployeeRepository), ServiceLifetime.Scoped));    // Scoped
            */

            // Application Service with Extension Methods
            /*
            services.AddSingleton<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
