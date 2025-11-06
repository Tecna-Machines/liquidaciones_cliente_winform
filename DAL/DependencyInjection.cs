using DAL.Service.Liquidacion.Features.Empleados.Abstracciones;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Contrato.Crear;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddLiquidacionApi(this IServiceCollection services)
        {
            services.AddScoped<ApiLiquidacion>();

            AddAcuerdos(services);
            AddEmpleados(services);

            return services;
        }

        private static IServiceCollection AddAcuerdos(this IServiceCollection services)
        {

            services.AddScoped<CrearAcuerdo>();
            services.AddScoped<IAcuerdoService, AcuerdoService>();
            return services;
        }

        private static IServiceCollection AddEmpleados(this IServiceCollection services)
        {
            services.AddScoped<DAL.Service.Liquidacion.UseCase.Empleados.Crear.CrearEmpleado>();
            services.AddScoped<GetTodosEmpleados>();

            services.AddScoped<IEmpleadoService, EmpleadoService>();
            return services;
        }
    }
}
