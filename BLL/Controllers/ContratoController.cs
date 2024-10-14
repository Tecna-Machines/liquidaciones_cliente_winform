using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato;
using LAUCHA.application.DTOs.ModalidadDTOs;

namespace BLL.Controllers
{
    public class ContratoController
    {
        private readonly ClienteLiq client;
        private readonly RecuperarModalidades _modalidades;

        public ContratoController()
        {
            client = new ClienteLiq();
            _modalidades = new(client);
        }

        public async Task<List<ModalidadDTO>> ObtenerModalidades()
        {
            return await _modalidades.recuperarModalidades();
        }
    }
}
