using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Empleados;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System.Net.Http;

namespace BLL.Controllers
{
    public class EmpleadoController
    {
        private readonly ClienteLiq ClienteHttp;
        private readonly RecuperarEmpleado recuperarEmpleados;
        private readonly DescargarRecibo descargarRecibo;

        public EmpleadoController()
        {
            ClienteHttp = new();
            recuperarEmpleados = new(ClienteHttp);
            descargarRecibo = new(ClienteHttp);
        }

        public async Task<EmpleadoDTO> ObtenerDataEmpleado(string dniEmp)
        {
            return await this.recuperarEmpleados.RecuperarEmpleadoDetalle(dniEmp);
        }

        public async Task<byte[]> DescargarReciboLiquidacionEmp(string codigoLiquidacion)
        {
            return await this.descargarRecibo.DescargarReciboAsync(codigoLiquidacion);
        }
    }
}
