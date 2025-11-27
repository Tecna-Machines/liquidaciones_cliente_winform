using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Liquidar;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones
{
    internal class LiquidacionService : ILiquidacionService
    {
        private readonly GetLiquidacion _getLiquidacionById;
        private readonly CrearLiquidacionHandler _crearLiquidacion;
        private readonly RealizarLiquidacion _realizarLiquidacion;
        private readonly AgregarItemLiquidacion _itemsLiquidacion;

        public LiquidacionService(GetLiquidacion getLiquidacionById,
                                  CrearLiquidacionHandler crearLiquidacion,
                                  RealizarLiquidacion realizarLiquidacion,
                                  AgregarItemLiquidacion itemsLiquidacion)
        {
            _getLiquidacionById = getLiquidacionById;
            _crearLiquidacion = crearLiquidacion;
            _realizarLiquidacion = realizarLiquidacion;
            _itemsLiquidacion = itemsLiquidacion;
        }

        public Task<GetLiquidacionByIdResponse> GetLiquidacion(string id)
        {
            return _getLiquidacionById.Get(id);
        }

        public Task<CrearLiquidacionResponse> Crear(CrearLiquidacionRequest req)
        {
            return _crearLiquidacion.CrearLiquidacion(req);
        }

        public Task<LiquidarResponse> Liquidar(string codigo)
        {
            return _realizarLiquidacion.Liquidar(codigo);
        }

        public Task<CrearItemResponse> AgregarItem(string codLiqudiacion, CrearItemRequest itemData)
        {
            return _itemsLiquidacion.CrearItem(codLiqudiacion, itemData);
        }
    }
}
