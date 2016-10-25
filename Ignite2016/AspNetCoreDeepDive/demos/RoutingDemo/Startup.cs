using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Routing;


namespace RoutingDemo
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Use((context, next) => {
                context.Response.ContentType = "text/plain";
                return next();
            });

            #region Simple routes
            var routes = new RouteBuilder(app)
                .MapGet("time", context => context.Response.WriteAsync(DateTime.Now.ToString()))
                .MapGet("random", context => context.Response.WriteAsync(new Random().Next(100).ToString()))
                .MapGet("hello/{name}", context =>
                {
                    var data = context.GetRouteData();
                    return context.Response.WriteAsync("Hello " + data.Values["name"]);
                })
                .Build();

            app.UseRouter(routes);
            #endregion

            #region MapRoute with default handler
            var defaultHandler = new RouteHandler(context =>
            {
                var data = context.GetRouteData().Values;
                return context.Response.WriteAsync(
                    String.Format("controller: {0}, action: {1}, id: {2}", data["controller"], data["action"], data["id"]));
            });

            // MapRoute adds a Route using the default route as the target
            routes = new RouteBuilder(app, defaultHandler)
                .MapRoute("test", "{controller}/{action}/{id?}")
                .Build();

            app.UseRouter(routes);
            #endregion
        }
    }
}
