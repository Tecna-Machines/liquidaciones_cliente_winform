using BLL.Models;
using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Contrato;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.ModalidadDTOs;

namespace BLL.Controllers
{
    public class ContratoController
    {
        private readonly ClienteLiq client;
        private readonly RecuperarModalidades _modalidades;
        private readonly ContratoService _crearContrato;
        public ContratoController()
        {
            client = new ClienteLiq();
            _modalidades = new(client);
            _crearContrato = new(client);
        }

        public async Task<List<ModalidadDTO>> ObtenerModalidades()
        {
            return await _modalidades.recuperarModalidades();
        }

        public async Task<ContratoDTO> CargarContrato(CrearContratoDTO contrato)
        {
            ContratoDTO contratoCreado;

            try
            {
                contratoCreado = await _crearContrato.CrearUnContrato(contrato);

            }catch(Exception)
            {
                throw new HttpRequestException();
            }

            ContratoContext.GetInstance().SetContrato(contratoCreado);
            return contratoCreado;
        }

        public async Task<ContratoDTO> ConsultarUnContrato(string codContrato)
        {
            return await _crearContrato.ObtenerContrato(codContrato);
        }
    }
}
