using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo;
using DAL.Service.Liquidacion.Features.Contrato.Abstracciones;
using DAL.Service.Liquidacion.Features.Contrato.Crear;
using DAL.Service.Liquidacion.Features.Contrato.GetAcuerdosEmpleado;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Empleados.Abstracciones;
using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using Microsoft.Extensions.DependencyInjection;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddScoped<ClientApiLiquidacion>();

            AddAcuerdos(services);
            AddEmpleados(services);
            AddLiquidacion(services);
            AddCatalogoRetenciones(services);

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

        private static IServiceCollection AddLiquidacion(this IServiceCollection services)
        {
            services.AddScoped<GetLiquidacion>();
            services.AddScoped<ILiquidacionService, LiquidacionService>();

            return services;
        }

        private static IServiceCollection AddCatalogoRetenciones(this IServiceCollection services)
        {
            services.AddScoped<GetRetenciones>();
            services.AddScoped<IRetencionesService, RetencionesService>();

            return services;
        }
    }
}
