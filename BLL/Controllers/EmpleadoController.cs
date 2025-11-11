using DAL.Service.Liquidacion.Features.Empleados.GetEmpleados;
using DAL.Service.Liquidacion.UseCase.Empleados.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Empleados.Crear;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.RetencionesFijasDTOs;

namespace BLL.Controllers
{
    public class EmpleadoController
    {

        private readonly IEmpleadoService _empleados;
        public EmpleadoController(IEmpleadoService empleados)
        {
            _empleados = empleados;
        }

        public async Task<GetEmpleadoResponse> ObtenerDataEmpleado(string dniEmp)
        {
            //return await this.recuperarEmpleados.RecuperarEmpleadoDetalle(dniEmp);
            throw new NotImplementedException();
        }

        public async Task<byte[]> DescargarReciboLiquidacionEmp(string codigoLiquidacion)
        {
            //return await this.descargarRecibo.DescargarReciboAsync(codigoLiquidacion);

            throw new NotImplementedException();
        }

        public async Task CrearEmpleado(CrearEmpleadoRequest empDto)
        {

            try
            {
                await _empleados.Crear(empDto);
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        public async Task<List<GetEmpleadoResponse>> ObtenerEmpleados()
        {
            var response = await _empleados.GetAll();
            return response.Empleados;
        }
        public async Task<List<RetencionFijaDTO>> ObtenerRetencionesFijasParaEmpleados()
        {
            //return await obtenerRetencionesFijas.ObtenerListaRetencionesFijas();
            throw new NotImplementedException();

        }

        public async Task ConfigurarRetencionesDeEmpleado(List<string> codigosRetenciones, string numeroCuenta)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResumenContratoDTO>> ObtenerHistorialContratosEmpleado(string dniEmp)
        {
            //return await _contratoService.ObtenerContratosEmpleados(dniEmp);
            throw new NotImplementedException();
        }
    }
}
