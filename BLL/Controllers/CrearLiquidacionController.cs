using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.LiquidacionDTOs;

namespace BLL.Controllers
{
    public class CrearLiquidacionController
    {
        private readonly ClientApiLiquidacion ClienteHttp;
        private readonly RecuperarEmpleadovIEJO recuperarEmpleados;
        private readonly ObtenerContratoEmpleadoVIEJO recuperarContrato;
        private readonly SimularLiquidacionEmpleado simulador;
        private readonly ConfirmarLiquidacion confirmarLiquidacion;

        public ConfirmarLiquidacion ConfirmarLiquidacion1 => confirmarLiquidacion;

        public CrearLiquidacionController(ClientApiLiquidacion api, SimularLiquidacionEmpleado simulador, ObtenerContratoEmpleadoVIEJO recuperarContrato, RecuperarEmpleadovIEJO recuperarEmpleados)
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

        public async Task<LiquidacionDTO> SimularLiquidacion(string dni, Quincena periodo)
        {
            return await simulador.SimularLiquidacion(dni, periodo);
        }

        public async Task<ContratoDTO> ObtenerContratoActual(string dniEmp)
        {
            return await recuperarContrato.ObtenerUltimoContratoEmp(dniEmp);
        }

        public async Task<LiquidacionDTO> ConfirmarLiquidacion(string dni, Quincena periodo)
        {
            return await ConfirmarLiquidacion1.CompletarLiquidacion(dni, periodo);
        }

    }
}
