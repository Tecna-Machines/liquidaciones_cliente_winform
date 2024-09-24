using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using System.Net;

namespace BLL.Controllers
{
    public class CrearLiquidacionController
    {
        private readonly ClienteLiq ClienteHttp;
        private readonly RecuperarEmpleado recuperarEmpleados;
        private readonly ObtenerContratoEmpleado recuperarContrato;
        private readonly SimularLiquidacionEmpleado simulador;
        private readonly ConfirmarLiquidacion confirmarLiquidacion;


        public CrearLiquidacionController()
        {

            ClienteHttp = new();
            recuperarEmpleados = new(ClienteHttp);
            recuperarContrato = new(ClienteHttp);
            simulador = new(ClienteHttp);
            confirmarLiquidacion = new(ClienteHttp);
        }

        public async Task<List<EmpleadoDTO>> ObtenerTodosLosEmpleado()
        {
            return await this.recuperarEmpleados.ObtenerEmpleados();
        }

        public async Task<LiquidacionDTO> SimularLiquidacion(string dni,PeriodoDTO periodo)
        {
            return await simulador.SimularLiquidacion(dni,periodo);
        }

        public async Task<ContratoDTO> ObtenerContratoActual(string dniEmp)
        {
            return await recuperarContrato.ObtenerUltimoContratoEmp(dniEmp);
        }

        public async Task<LiquidacionDTO> ConfirmarLiquidacion(string dni,PeriodoDTO periodo)
        {
           return await confirmarLiquidacion.CompletarLiquidacion(dni, periodo);
        }

    }
}
