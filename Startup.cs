using ElectronNET.API;
using ElectronNET.API.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PsyWagonLestes.Data;

namespace PsyWagonLestes
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();

            services.AddDbContext<PsyWagonLestesContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("PsyWagonLestesContext")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

            if (HybridSupport.IsElectronActive)
            {
                CreateWindow();
            }
        }

        private async void CreateWindow()
        {
            //electron
            //Task.Run(async () => await Electron.WindowManager.CreateWindowAsync());
            //var window = await  Electron.WindowManager.CreateWindowAsync();

            //FullScreen
            var browserWindow = await Electron.WindowManager.CreateWindowAsync(new BrowserWindowOptions
            {
                Width = 1152,
                Height = 940,
                Show = false
            });
            await browserWindow.WebContents.Session.ClearCacheAsync();
            browserWindow.OnReadyToShow += () =>
            {
                browserWindow.Show();
                browserWindow.Maximize();
            };
            //отключение меню
            Electron.Menu.SetApplicationMenu(new MenuItem[] { });
            //обработчик закрытия
            browserWindow.OnClosed += () =>
            {
                Electron.App.Quit();
            };
        }
    }
}