using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.AnularItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetRecibo;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Liquidar;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Pagar;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Sellar;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones
{
    internal class LiquidacionService : ILiquidacionService
    {
        private readonly GetLiquidacion _getLiquidacionById;
        private readonly CrearLiquidacionHandler _crearLiquidacion;
        private readonly RealizarLiquidacion _realizarLiquidacion;
        private readonly AgregarItemLiquidacion _itemsLiquidacion;
        private readonly GetLiquidaciones _getLiquidaciones;
        private readonly SellarLiquidacion _sellar;
        private readonly AnularItemHandler _anularItems;
        private readonly GetReciboHandler _recibo;
        private readonly PagarLiquidacionHandler _pagarLiquidacion;
        public LiquidacionService(GetLiquidacion getLiquidacionById,
                                  CrearLiquidacionHandler crearLiquidacion,
                                  RealizarLiquidacion realizarLiquidacion,
                                  AgregarItemLiquidacion itemsLiquidacion,
                                  GetLiquidaciones getLiquidaciones,
                                  SellarLiquidacion sellar,
                                  AnularItemHandler anularItems,
                                  GetReciboHandler recibo,
                                  PagarLiquidacionHandler pagarLiquidacion)
        {
            _getLiquidacionById = getLiquidacionById;
            _crearLiquidacion = crearLiquidacion;
            _realizarLiquidacion = realizarLiquidacion;
            _itemsLiquidacion = itemsLiquidacion;
            _getLiquidaciones = getLiquidaciones;
            _sellar = sellar;
            _anularItems = anularItems;
            _recibo = recibo;
            _pagarLiquidacion = pagarLiquidacion;
        }

        public Task<GetLiquidacionByIdResponse?> GetLiquidacion(string id)
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

        public async Task<GetLiquidacionesResponse> GetByQuincena(int quincena, int mes, int anio)
        {
            return await _getLiquidaciones.GetByQuincena(quincena, mes, anio);
        }

        public async Task<SellarLiquidacionResponse> Sellar(string codigo)
        {
            return await _sellar.Sellar(codigo);
        }

        public void AnularItem(string idLiquidacion, int NroItem)
        {
            _anularItems.CancelarItem(idLiquidacion, NroItem);
        }

        public async Task<byte[]> GetRecibo(string codigo)
        {
            return await _recibo.GetRecibo(codigo);
        }

        public async Task<byte[]> GetRecibos(int quincena, int mes, int anio)
        {
            return await _recibo.GetRecibos(quincena, mes, anio);
        }

        public async Task<PagoCreadoResponse> Pagar(CrearPagoRequest crearPago)
        {
            return await _pagarLiquidacion.PagarLiquidacion(crearPago);
        }
    }
}
