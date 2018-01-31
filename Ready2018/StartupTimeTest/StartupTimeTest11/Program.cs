using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using System.Diagnostics;
using System.Net.Http;

namespace StartupTimeTest11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var stopwatch = Stopwatch.StartNew();

            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseApplicationInsights()
                .Build();

            host.Start();

            using (var http = new HttpClient())
            {
                var home = http.GetStringAsync("http://localhost:5000").Result;
                var headingLocation = home.IndexOf("Sample pages using ASP.NET Core MVC");
                if (headingLocation < 0)
                {
                    throw new Exception("Hmmm, can't find home page text");
                }
            }

            host.Dispose();
            stopwatch.Stop();

            Console.WriteLine($"Time to start-up, retrieve home page, and shutdown: {stopwatch.Elapsed}");

        }
    }
}
