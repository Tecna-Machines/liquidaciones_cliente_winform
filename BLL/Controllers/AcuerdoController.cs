using DAL.Service.Liquidacion.UseCase.Contrato.Abstracciones;
using DAL.Service.Liquidacion.UseCase.Contrato.Crear;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.ModalidadDTOs;

namespace BLL.Controllers
{
    public class AcuerdoController
    {
        private readonly IAcuerdoService _service;
        public AcuerdoController(IAcuerdoService service)
        {
            _service = service;
        }

        public List<ModalidadDTO> ObtenerModalidades()
        {
            var Mensual = new ModalidadDTO { Codigo = "10", Descripcion = "mensual" };
            var MensualFijoMasExtra = new ModalidadDTO { Codigo = "12", Descripcion = "mensual fijo mas extra" };
            var QuincenalHora = new ModalidadDTO { Codigo = "20", Descripcion = "quincenal hora" };
            var QuincenalFijo = new ModalidadDTO { Codigo = "22", Descripcion = "quincenal fijo" };

            return new List<ModalidadDTO> { Mensual, MensualFijoMasExtra, QuincenalFijo, QuincenalHora };
        }

        public async Task<string> CargarAcuerdo(CrearAcuerdoRequest acuerdo)
        {
            string codigoAcuerdo;

            try
            {
                codigoAcuerdo = await _service.Crear(acuerdo);

            }
            catch (Exception)
            {
                throw new HttpRequestException();
            }

            return codigoAcuerdo;
        }

        public async Task<ContratoDTO> ConsultarAcuerdo(string codContrato)
        {
            throw new NotImplementedException();
        }
    }
}
