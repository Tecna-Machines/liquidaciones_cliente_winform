using DAL.Service.Liquidacion.Features.Contrato.Abstracciones;
using DAL.Service.Liquidacion.Features.Contrato.Crear;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Empleados.Abstracciones;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
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
            services.AddScoped<GetAcuerdoById>();
            services.AddScoped<GetAcuerdoEmpleadoHandler>();
            services.AddScoped<IAcuerdoService, AcuerdoService>();
            return services;
        }

        private static IServiceCollection AddEmpleados(this IServiceCollection services)
        {
            services.AddScoped<CrearEmpleado>();
            services.AddScoped<GetTodosEmpleados>();

            services.AddScoped<IEmpleadoService, EmpleadoService>();
            return services;
        }
    }
}
