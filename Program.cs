using ElectronNET.API;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace PsyWagonLestes
{
    //EntityFramework\Add-Migration � EntityFrameworkCore\Add-Migration �������� ��������
    //Update-Database ����������� ��
    //Get-Migration �������� ������

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
                    webBuilder.UseElectron(args);
                    webBuilder.UseStartup<Startup>();
                });
    }
}