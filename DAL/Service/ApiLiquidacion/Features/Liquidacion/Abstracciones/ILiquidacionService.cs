using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.CrearLiquidacion;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Liquidar;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Sellar;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace DAL.Service.Liquidacion.Features.Liquidacion.Abstracciones
{
    public interface ILiquidacionService
    {
        Task<GetLiquidacionByIdResponse?> GetLiquidacion(string id);
        Task<CrearLiquidacionResponse> Crear(CrearLiquidacionRequest req);
        Task<LiquidarResponse> Liquidar(string codigo);
        Task<CrearItemResponse> AgregarItem(string codLiqudiacion, CrearItemRequest itemData);
        Task<GetLiquidacionesResponse> GetByQuincena(int quincena, int mes, int anio);
        Task<SellarLiquidacionResponse> Sellar(string codigo);
        void AnularItem(string codLiquidacion, int NroItem);

        Task<byte[]> GetRecibo(string idLiquidacion);
        Task<byte[]> GetRecibos(int quincena,int mes,int anio);
    }
}
