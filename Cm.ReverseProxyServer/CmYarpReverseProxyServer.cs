using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Cm.ReverseProxyServer
{
    public class CmYarpReverseProxyServer
    {
        public void run(string[] args)
        {
            bool firstMethod = true;
            if (firstMethod)
            {
                var builder = Host.CreateDefaultBuilder(args)
                    .ConfigureAppConfiguration((context, configurationBuilder) =>
                    {
                        // 기본 appsettings.json의 파일이름을 변경하기 위해서.
                        configurationBuilder
                             .AddJsonFile("yarpappsettings.json", false);
                    });

                builder.ConfigureWebHostDefaults(webHostBuilder =>
                {
                    webHostBuilder.UseStartup<Startup>();
                });

                var myHost = builder.Build();
                myHost.Run();
            }
            else
            {
                /* https://devblogs.microsoft.com/dotnet/announcing-yarp-1-0-release/
                builder = WebApplication.CreateBuilder(args);

                builder.Services.AddReverseProxy()
                    .LoadFromConfig(builder.Configuration.GetSection("ReverseProxy"));

                var app = builder.Build();

                app.MapReverseProxy();

                app.Run();
                */
            }
        }
    }
}