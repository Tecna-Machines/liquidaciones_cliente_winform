using Microsoft.Extensions.DependencyInjection;
using UI.Screens.CrearContrato;
using UI.Screens.CrearEmpleado;
using UI.Screens.HacerLiquidacion;
using UI.Screens.VerContratos;
using UI.Screens.VerLiquidacion;

namespace UI
{
    internal static class DependencyInjections
    {
        public static IServiceCollection AddFormsServices(this IServiceCollection services)
        {
            services.AddScoped<CrearAcuerdoForm>();
            services.AddScoped<VerAcuerdosForm>();
            services.AddScoped<VerLiquidacionForm>();
            services.AddScoped<CrearLiquidacionForm>();
            services.AddScoped<CrearEmpleadoForm>();
            return services;
        }
    }
}
