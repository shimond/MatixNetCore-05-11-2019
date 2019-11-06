using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using webApiEx.Contracts;
using webApiEx.mw;

namespace webApiEx
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
            //services.AddLogging(x => x.AddEventLog());
            //services.Configure<>
            //services.AddSingleton<ICurrencyService, CurrencyService>();
            //services.AddTransient<ICurrencyService, CurrencyService>();
            services.AddTransient<IPeopleService, PeopleService>();
            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            //app.UseStaticFiles();
            //app.UseDefaultFiles();
            //app.UseMatrixMiddleware();
            
            //app.Use(async (requestContext, next) =>
            //{
            //    await requestContext.Response.WriteAsync("Middleware1 (appuse1)");
            //    await next();
            //    await requestContext.Response.WriteAsync("    Middleware1 (appuse2)");
            //});

            //app.Run(async (context) => {
            //    await context.Response.WriteAsync("App.Run");
            //});

            //app.Use(async (requestContext, next) =>
            //{
            //    await requestContext.Response.WriteAsync("Middleware2 (appuse1)");
            //    await requestContext.Response.WriteAsync("    Middleware2 (appuse2)");
            //});

        }



    }
}
