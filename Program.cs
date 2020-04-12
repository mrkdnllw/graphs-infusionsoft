using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace GraphsInfusionsoft
{
    public class Program
    {
        public static void Main(string[] args)
        {
             CreateHostBuilder(args).Build().Run();
            /*var host = new WebHostBuilder()
               .UseKestrel()
               //.UseContentRoot(Directory.GetCurrentDirectory())
               .UseContentRoot(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location))
               .UseIISIntegration()
               .UseStartup()
               .Build();*/

            //host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
