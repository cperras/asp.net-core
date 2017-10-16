using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace EchoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel(opts =>
                {
                    opts.Limits.MaxConcurrentConnections = null;
                    opts.Limits.MaxConcurrentUpgradedConnections = null;
                    // opts.Limits.KeepAliveTimeout
                    // opts.ApplicationSchedulingMode

                    // opts.Limits.KeepAliveTimeout
                    // opts.
                })
                .UseContentRoot(Directory.GetCurrentDirectory())
                // .UseIISIntegration()
                // .UseApplicationInsights()
                .UseStartup<Startup>()
                .Build();

            host.Run();
        }
    }
}
