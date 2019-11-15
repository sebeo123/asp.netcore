using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ConfigurationSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.Run(async (context) =>
            {
                // await context.Response.WriteAsync(Configuration.GetSection("Message").Value);//lenh goi 1 phan tu trong appsetting.json
                // await context.Response.WriteAsync(Configuration.GetSection("ConnectionStrings:OracleServerConnectionString").Value); //lenh goi phan tu con trong phan tu cha
                // await context.Response.WriteAsync(Configuration.GetSection("Student:0:Name").Value);// lenh goi phan tu con trong array
                // await context.Response.WriteAsync(Configuration.GetSection("Arg1").Value); //dung lenh cmd dotnet run Arg1=value
               // await context.Response.WriteAsync(Configuration.GetSection("PATH").Value); //test
            });
        }
    }
}
