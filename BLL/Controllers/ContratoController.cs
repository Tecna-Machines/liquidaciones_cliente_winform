using DAL.Service.Liquidacion.UseCase.Contrato;
using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.ModalidadDTOs;

namespace BLL.Controllers
{
    public class ContratoController
    {
        private readonly IAcuerdoService _service;
        public ContratoController(IAcuerdoService service)
        {
            _service = service;
        }

        public async Task<List<ModalidadDTO>> ObtenerModalidades()
        {
            var Mensual = new ModalidadDTO { Codigo = "10", Descripcion = "mensual" };
            var MensualFijoMasExtra = new ModalidadDTO { Codigo = "12", Descripcion = "mensual fijo mas extra" };
            var QuincenalHora = new ModalidadDTO { Codigo = "20", Descripcion = "quincenal hora" };
            var QuincenalFijo = new ModalidadDTO { Codigo = "22", Descripcion = "quincenal fijo" };

            return new List<ModalidadDTO> { Mensual, MensualFijoMasExtra, QuincenalFijo, QuincenalHora };
        }

        public async Task<string> CargarContrato(CrearAcuerdoRequest contrato)
        {
            string codigoAcuerdo;

            try
            {
                codigoAcuerdo = await _service.Crear(contrato);

            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }

            return codigoAcuerdo;
        }

        public async Task<ContratoDTO> ConsultarUnContrato(string codContrato)
        {
            throw new NotImplementedException();
        }
    }
}
