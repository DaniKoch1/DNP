using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Session10.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;

namespace Session10
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CreateWebHostBuilder(args).Build().Run();
            var host= BuildWebHost(args);
            using(var scope =host.Services.CreateScope()){
                var services =scope.ServiceProvider;
                try{
                    var context =services.GetRequiredService<CatContext>();
                    DbInitializer.Initialize(context);
                }
                catch (Exception e){
                    var logger=services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(e, "An error occured while seeding the db");
                }
            }
            host.Run();
        }

        // public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
        //     WebHost.CreateDefaultBuilder(args)
        //         .UseStartup<Startup>();

    }
}
