using BLL.Controllers;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using Microsoft.Extensions.DependencyInjection;

namespace BLL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddControllers(this IServiceCollection services)
        {

            services.AddScoped<ConfirmarLiquidacion>();
            services.AddScoped<SimularLiquidacionEmpleado>();
            services.AddScoped<ObtenerContratoEmpleado>();
            services.AddScoped<RecuperarEmpleado>();
            services.AddScoped<CrearLiquidacionController>();
            services.AddScoped<AcuerdoController>();
            services.AddScoped<EmpleadoController>();
            return services;
        }
    }
}
