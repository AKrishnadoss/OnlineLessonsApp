using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using AutoMapper;
using ClassicalDanceWeb.Data;
using Microsoft.EntityFrameworkCore;
using ClassicalDanceWeb.Models;

namespace ClassicalDanceWeb
{
    public class Startup
    {
        private readonly IConfiguration _config;
        private readonly IWebHostEnvironment _environment;

        public Startup(IConfiguration config, IWebHostEnvironment environment)
        {
            this._config = config;
            this._environment = environment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/dist";
            });

            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();
            services.AddMemoryCache();

            string connectionString = @"Server=NIRANJANAKILA\SQLEXPRESS;Initial Catalog=DanceDb;User id=sa;password=admin123;";
            services.AddDbContext<DanceDBContext>(config =>
            {
                config.UseSqlServer(connectionString);
            });

            services.AddTransient<IDanceRepository, DanceRepository>();
            services.AddTransient<IStudentModel, StudentModel>();

            services.AddMvc(config =>
            {
                if (_environment.IsDevelopment())
                {
                    config.SslPort = 51344;
                }
                config.Filters.Add(new RequireHttpsAttribute());
                
            })
               .SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0);

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
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

        }
    }
}
