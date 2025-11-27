using Microsoft.Extensions.DependencyInjection;
using UI.Screens.CrearContrato;
using UI.Screens.CrearEmpleado;
using UI.Screens.HacerLiquidacion;
using UI.Screens.Liquidaciones.HistorialLiquidaciones;
using UI.Screens.VerContratos;
using UI.Screens.VerLiquidacion;

namespace UI
{
    internal static class DependencyInjections
    {
        public static IServiceCollection AddFormsServices(this IServiceCollection services)
        {
            services.AddTransient<CrearAcuerdoForm>();
            services.AddTransient<VerAcuerdosForm>();
            services.AddTransient<VerLiquidacionForm>();
            services.AddTransient<CrearLiquidacionForm>();
            services.AddTransient<CrearEmpleadoForm>();
            services.AddTransient<CrearItemForm>();
            services.AddTransient<HistorialLiquidacionesForm>();
            return services;
        }
    }
}
