using DAL.Service.Liquidacion.Http;
using DAL.Service.Liquidacion.UseCase.Liquidacion;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using LAUCHA.application.DTOs.PaginaDTOs;

namespace BLL.Controllers
{
    public class ConsultarLiquidacionController
    {
        private readonly ClienteLiq client;
        private readonly RecuperarLiquidaciones recuperarLiquidaciones;
        public ConsultarLiquidacionController()
        {
            this.client = new ClienteLiq();
            this.recuperarLiquidaciones = new(this.client);
        }

        public async Task<PaginaDTO<LiquidacionResumenDTO>> ConsultarLiquidaciones(FiltroLiquidacion filtro)
        {
            return await this.recuperarLiquidaciones.RecuperarLiquidacionesFiltradas(filtro);
        }

        public async Task<LiquidacionDTO> ConsultarLiquidacionById(string codigo)
        {
            return await this.recuperarLiquidaciones.RecuperarLiquidacion(codigo);
        }
    }
}
