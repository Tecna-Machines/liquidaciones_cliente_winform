using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones
{
    public interface ILiquidacionService
    {
        public Task<GetLiquidacionByIdResponse> GetLiquidacion(string id);
    }
}
