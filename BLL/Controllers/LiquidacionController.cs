using DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace BLL.Controllers
{
    public class LiquidacionController
    {
        private readonly ILiquidacionService _liquidacion;

        public LiquidacionController(ILiquidacionService liquidacion)
        {
            _liquidacion = liquidacion;
        }

        public async Task<GetLiquidacionByIdResponse> GetById(string id)
        {
            return await _liquidacion.GetLiquidacion(id);
        }
    }
}
