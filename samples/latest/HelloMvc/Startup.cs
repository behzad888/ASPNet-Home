using Microsoft.AspNet.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace HelloMvc
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            
            app.UseIISPlatformHandler();
            
            app.UseDeveloperExceptionPage();

            app.UseMvcWithDefaultRoute();

            app.UseWelcomePage();
        }
        
        // public static void Main(string[] args)
        // {
        //     var host = new WebHostBuilder()
        //         .UseDefaultHostingConfiguration(args)
        //         .UseStartup<Startup>()
        //         .Build();

        //     host.Run();
        // }
    }
}