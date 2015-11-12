using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.Framework.DependencyInjection;

namespace MVC6Demo
{
  public class Startup
  {
    // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
    public void ConfigureServices(IServiceCollection services)
    {
      services.AddMvc();
      services.AddTransient<MVC6Demo.Models.HeroStats>();
    }

    public void Configure(IApplicationBuilder app)
    {
      app.UseMvc(m =>
      {
        m.MapRoute(
          name: "default",
          template: "{controller}/{action}/{id?}",
          defaults: new
          {
            controller = "Home",
            action = "Index"
          });
      });

      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Hello World!");
      });
    }
  }
}
