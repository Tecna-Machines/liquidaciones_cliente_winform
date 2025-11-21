using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones
{
    internal class LiquidacionService : ILiquidacionService
    {
        private readonly GetLiquidacion _getLiquidacionById;

        public LiquidacionService(GetLiquidacion getLiquidacionById)
        {
            _getLiquidacionById = getLiquidacionById;
        }

        public Task<GetLiquidacionByIdResponse> GetLiquidacion(string id)
        {
            return _getLiquidacionById.Get(id);
        }
    }
}
