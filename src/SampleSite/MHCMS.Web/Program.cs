using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using MHCMS.StartupDependencies;
using Microsoft.AspNetCore.Builder;
using System.IO;

namespace MHCMS.SampleSite.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
               Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder
                        .UseContentRoot(Directory.GetCurrentDirectory())
                        .UseStartup<Startup>();
            });
    }
}
