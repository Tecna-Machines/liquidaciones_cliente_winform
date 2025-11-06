using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.LiquidacionDTOs;

namespace BLL.Controllers
{
    public class CrearLiquidacionController
    {
        private readonly ApiLiquidacion ClienteHttp;
        private readonly RecuperarEmpleado recuperarEmpleados;
        private readonly ObtenerContratoEmpleado recuperarContrato;
        private readonly SimularLiquidacionEmpleado simulador;
        private readonly ConfirmarLiquidacion confirmarLiquidacion;

        public ConfirmarLiquidacion ConfirmarLiquidacion1 => confirmarLiquidacion;

        public CrearLiquidacionController(ApiLiquidacion api, SimularLiquidacionEmpleado simulador, ObtenerContratoEmpleado recuperarContrato, RecuperarEmpleado recuperarEmpleados)
        {

            ClienteHttp = api;
            recuperarContrato = new(ClienteHttp);
            confirmarLiquidacion = new(ClienteHttp);
            this.simulador = simulador;
            this.recuperarContrato = recuperarContrato;
            this.recuperarEmpleados = recuperarEmpleados;
        }

        public async Task<List<GetEmpleadoResponse>> ObtenerTodosLosEmpleado()
        {
            return await this.recuperarEmpleados.ObtenerEmpleados();
        }

        public async Task<LiquidacionDTO> SimularLiquidacion(string dni, PeriodoDTO periodo)
        {
            return await simulador.SimularLiquidacion(dni, periodo);
        }

        public async Task<ContratoDTO> ObtenerContratoActual(string dniEmp)
        {
            return await recuperarContrato.ObtenerUltimoContratoEmp(dniEmp);
        }

        public async Task<LiquidacionDTO> ConfirmarLiquidacion(string dni, PeriodoDTO periodo)
        {
            return await ConfirmarLiquidacion1.CompletarLiquidacion(dni, periodo);
        }

    }
}
