using DAL.Service.Liquidacion.Features.Contrato.Crear;
using DAL.Service.Liquidacion.Features.Contrato.GetById;
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

        public List<ModalidadDTO> ObtenerTiposDeSueldo()
        {
            var Mensual = new ModalidadDTO { Codigo = "10", Descripcion = "MENSUAL FIJO (SIN EXTRAS)" };
            var MensualFijoMasExtra = new ModalidadDTO { Codigo = "12", Descripcion = "MENSUAL FIJO + HS EXTRAS" };
            var QuincenalHora = new ModalidadDTO { Codigo = "20", Descripcion = "QUINCENAL FIJO + HS EXTRAS" };
            var QuincenalFijo = new ModalidadDTO { Codigo = "22", Descripcion = "QUINCENAL FIJO (SIN EXTRAS)" };

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

        public async Task<GetAcuerdoByIdResponse> GetAcuerdo(string codContrato)
        {
            return await _service.GetById(codContrato);
        }
    }
}
