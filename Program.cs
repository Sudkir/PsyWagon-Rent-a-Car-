using ElectronNET.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PsyWagonLestes
{
    //cmd
    //dotnet tool install --global ElectronNET.CLI --version 13.5.1
    //CMD NutGet
    // dotnet tool install --local ElectronNET.CLI --version 13.5.1
    //dotnet tool update ElectronNET.CLI -g
    //electronize init
    //electronize start

    //Install-Package ElectronNET.API
    //Import-Module EntityFramework
    //EntityFramework\Add-Migration и EntityFrameworkCore\Add-Migration Создание миграции
    //Update-Database обноваление БД
    //Get-Migration получить список

    //https://html5book.ru/tablica-cen-s-pereklyuchatelem/ CSS HTML
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
                    //electron
                    webBuilder.UseElectron(args);
                    webBuilder.UseEnvironment("Development");
                    //def
                    webBuilder.UseStartup<Startup>();
                });
    }
}