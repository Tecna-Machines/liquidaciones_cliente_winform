using BLL.Controllers;
using Microsoft.Extensions.DependencyInjection;
using UI.Screens.CrearContrato;

namespace UI
{
    internal static class DependencyInjections
    {
        public static IServiceCollection AddFormsServices(this IServiceCollection services)
        {
            services.AddScoped<CrearAcuerdoForm>();
            return services;
        }
    }
}
