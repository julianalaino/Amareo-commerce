using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Catalog.Service.Queries;
using MediatR;
using System.Reflection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
using Common.Logging;
using Microsoft.Extensions.Logging;

namespace Catalog.Api
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
            services.AddDbContext<ApplicationDbContext>(opts =>

                    opts.UseSqlServer(

                        Configuration.GetConnectionString("DefaultConnection"),
                        x => x.MigrationsHistoryTable("_EFMigrationHistory","Catalog")
                        )

                );

            services.AddHealthChecksUI()
                .AddInMemoryStorage();

            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy())
                .AddDbContextCheck<ApplicationDbContext>();

            

            services.AddMediatR(Assembly.Load("Catalog.Service.EventHandlers"));

            services.AddTransient<IProductQueryService, ProductQueryService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //Si no es entorno de desarrollo
            if (!env.IsDevelopment())
            {

                loggerFactory.AddSyslog(Configuration.GetValue<string>("Papertrail:host"),
                                   Configuration.GetValue<int>("Papertrail:port")
               );

            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHealthChecks("/hc" , new HealthCheckOptions()
                {
                    Predicate = _ => true,
                    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
                });
                endpoints.MapHealthChecksUI();
                endpoints.MapControllers();
            });
        }
    }
}
