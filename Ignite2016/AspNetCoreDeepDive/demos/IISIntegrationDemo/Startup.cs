using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.Extensions.Configuration;

namespace IISIntegrationDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                context.Response.ContentType = "text/plain";
                var addresses = app.ServerFeatures.Get<IServerAddressesFeature>().Addresses;
                foreach (var address in addresses)
                {
                    await context.Response.WriteAsync(address + Environment.NewLine);
                }
                var config = new ConfigurationBuilder().AddEnvironmentVariables().Build();
                await context.Response.WriteAsync(config["ASPNETCORE_PORT"] + Environment.NewLine);
                await context.Response.WriteAsync(config["ASPNETCORE_APPL_PATH"] + Environment.NewLine);
                await context.Response.WriteAsync(config["ASPNETCORE_TOKEN"] + Environment.NewLine);
            });
        }
    }
}
