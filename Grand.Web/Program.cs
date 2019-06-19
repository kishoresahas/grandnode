using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Grand.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                 .ConfigureAppConfiguration(builder =>
                    {
                        builder.Sources.Clear();
                    })
                .CaptureStartupErrors(true)
                .UseSetting(WebHostDefaults.PreventHostingStartupKey, "true")
                .UseStartup<Startup>();
    }
}