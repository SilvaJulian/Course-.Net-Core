using System;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace netCoreWorkshop
{
    class Program
    {
      
public static void Main(string[] args)
{
	CreateWebHostBuilder(args).Build().Run();
}

public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
	WebHost.CreateDefaultBuilder(args)
		//.Configure(app => app.Run(context => context.Response.WriteAsync("Hello World, from ASP.NET!")));
        .UseStartup<Startup>();
    }
}
