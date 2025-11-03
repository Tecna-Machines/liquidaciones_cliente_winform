using BLL.Controllers;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        services.AddScoped<ContratoController>();
            return services;
        }
    }
}
