using BLL;
using DAL;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Globalization;

namespace UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //cultura
            CultureInfo cultureInfo = new CultureInfo("es-AR");
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            var host = CreateHostBuilder().Build();
            ServiceProvider = host.Services;

            ApplicationConfiguration.Initialize();

            // ?? scope para que los servicios Scoped (p.ej. DbContext) tengan vida correcta
            using var scope = ServiceProvider.CreateScope();
            var home = scope.ServiceProvider.GetRequiredService<Home>();
            Application.Run(home);
        }
        public static IServiceProvider ServiceProvider { get; private set; }

        static IHostBuilder CreateHostBuilder()
        {
            return Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {

                    services.AddLiquidacionApi();
                    services.AddControllers();
                    services.AddFormsServices();

                    services.AddScoped<Home>();
                });
        }

    }
}