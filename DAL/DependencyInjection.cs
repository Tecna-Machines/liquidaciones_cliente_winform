using DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.AnularItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetRecibo;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Liquidar;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Sellar;
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
            AddCreditos(services);

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
            services.AddScoped<CrearLiquidacionHandler>();
            services.AddScoped<RealizarLiquidacion>();
            services.AddScoped<AgregarItemLiquidacion>();
            services.AddScoped<GetLiquidaciones>();
            services.AddScoped<SellarLiquidacion>();
            services.AddScoped<AnularItemHandler>();
            services.AddScoped<GetReciboHandler>();

            services.AddScoped<ILiquidacionService, LiquidacionService>();

            return services;
        }

        private static IServiceCollection AddCatalogoRetenciones(this IServiceCollection services)
        {
            services.AddScoped<GetRetenciones>();
            services.AddScoped<IRetencionesService, RetencionesService>();

            return services;
        }

        private static IServiceCollection AddCreditos(this IServiceCollection services)
        {
            services.AddScoped<CrearCredito>();
            services.AddScoped<ICreditoService,CreditoService>();
            return services;
        }
    }
}
