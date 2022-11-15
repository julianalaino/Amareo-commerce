using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Order.Persistence.Database;
using Microsoft.EntityFrameworkCore;
using Order.Service.Proxies;
using Order.Service.Proxies.Catalog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using MediatR;
using System.Reflection;
using Order.Service.Queries;
using Common.Logging;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Order.Api
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
                        x => x.MigrationsHistoryTable("_EFMigrationHistory", "Order")
                        )

                );

            services.AddHttpContextAccessor();

            //HealthChecks
            services.AddHealthChecksUI()
                .AddInMemoryStorage();

            services.AddHealthChecks()
                .AddCheck("self", () => HealthCheckResult.Healthy())
                .AddDbContextCheck<ApplicationDbContext>();

            services.AddMediatR(Assembly.Load("Order.Service.EventHandlers"));

            services.AddTransient<IOrderQueryService, OrderQueryService>();

            //Api Urls
            services.Configure<ApiUrls>(
                opts => Configuration.GetSection("ApiUrls").Bind(opts));

            //Proxies
            //services.AddHttpClient<ICatalogProxy, CatalogHttpProxy>();
            services.AddTransient<ICatalogProxy, CatalogQueueProxy>();

            services.AddControllers();

            // Add Authentication
            var secretKey = Encoding.ASCII.GetBytes(
                Configuration.GetValue<string>("SecretKey")
            );

            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(secretKey),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
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
                endpoints.MapHealthChecks("/hc", new HealthCheckOptions()
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
