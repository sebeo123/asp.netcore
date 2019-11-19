using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing.Constraints;
using Microsoft.Extensions.DependencyInjection;

namespace MVCCoreApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseMvc(routes =>
            {
            //     routes.MapRoute("testcustomer", "testcustomer", new
            // {
            //        Controller = "Customer",
            //      Action = "Index"
            //});
            routes.MapRoute("default", "{controller=Home}/{action=Index}/{id:int?}");
                //routes.MapRoute("default", "{controller}/{action}/{id}", new{controller = "Home", action = "Index"},
                //    new {id = new IntRouteConstraint()});
                //routes.MapRoute("default", "post/{id:int}", new {controller = "Post", action = "PostsByID"});
                //routes.MapRoute("anotherRoute", "post/{id:alpha}", new { controller = "Post", action = "PostsByPostName" });

            });

            //app.UseMvcWithDefaultRoute();
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("failed to find route");
            });
        }
    }
}
