using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using DAL.Service.Liquidacion.UseCase.RetencionesFijas;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.RetencionesFijasDTOs;

namespace BLL.Controllers
{
    public class EmpleadoController
    {
        private readonly ClienteLiq ClienteHttp;
        private readonly RecuperarEmpleado recuperarEmpleados;
        private readonly DescargarRecibo descargarRecibo;
        private readonly CrearEmpleado crearEmpleado;
        private readonly ObtenerRetencionesFijas obtenerRetencionesFijas;
        private readonly ContratoService _contratoService;
        public EmpleadoController()
        {
            ClienteHttp = new();
            recuperarEmpleados = new(ClienteHttp);
            descargarRecibo = new(ClienteHttp);
            crearEmpleado = new(ClienteHttp);
            obtenerRetencionesFijas = new(ClienteHttp);
            _contratoService = new(ClienteHttp);
        }

        public async Task<EmpleadoDTO> ObtenerDataEmpleado(string dniEmp)
        {
            return await this.recuperarEmpleados.RecuperarEmpleadoDetalle(dniEmp);
        }

        public async Task<byte[]> DescargarReciboLiquidacionEmp(string codigoLiquidacion)
        {
            return await this.descargarRecibo.DescargarReciboAsync(codigoLiquidacion);
        }

        public async Task<EmpleadoDTO> CrearNuevoEmpleado(string dni, string nombre, string apellido, DateTime fechaIng, DateTime fechaNac)
        {

            var empDto = new CrearEmpleadoDTO
            {
                Dni = dni,
                Nombre = nombre,
                Apellido = apellido,
                FechaIngreso = fechaIng,
                FechaNacimiento = fechaNac
            };

            try
            {
                var emp = await crearEmpleado.CrearUnEmpleado(empDto);
                return emp;
            }
            catch (Exception)
            {
                throw new ArgumentException();
            }
        }

        public async Task<List<RetencionFijaDTO>> ObtenerRetencionesFijasParaEmpleados()
        {
            return await obtenerRetencionesFijas.ObtenerListaRetencionesFijas();
        }

        public async Task ConfigurarRetencionesDeEmpleado(List<string> codigosRetenciones,string numeroCuenta)
        {
            await this.crearEmpleado.AsignarRetencionesEmpleado(codigosRetenciones,numeroCuenta);
        }

        public async Task<List<ResumenContratoDTO>> ObtenerHistorialContratosEmpleado(string dniEmp)
        {
            return await _contratoService.ObtenerContratosEmpleados(dniEmp);
        }
    }
}
