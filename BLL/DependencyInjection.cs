using BLL.Controllers;
using DAL.Service.Liquidacion.UseCase.Empleados;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {

            services.AddScoped<ObtenerContratoEmpleadoVIEJO>();
            services.AddScoped<RecuperarEmpleadovIEJO>();
            services.AddScoped<AcuerdoController>();
            services.AddScoped<EmpleadoController>();
            services.AddScoped<RetencionController>();
            services.AddScoped<LiquidacionController>();
            services.AddScoped<CreditoController>();
            services.AddScoped<FeriadoController>();
            services.AddScoped<CuentasContablesController>();

            return services;
        }
    }
}
