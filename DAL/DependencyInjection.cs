using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Contrato.Crear;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLiquidacionApi(this IServiceCollection services)
        {
            services.AddScoped<ApiLiquidacion>();
            services.AddScoped<CrearAcuerdo>();
            services.AddScoped<IAcuerdoService, AcuerdoService>();

            return services;
        }
    }
}
