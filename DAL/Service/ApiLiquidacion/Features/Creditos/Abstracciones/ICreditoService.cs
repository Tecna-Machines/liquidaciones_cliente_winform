using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.ApiLiquidacion.Features.Creditos.CrearPlanPago;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones
{
    public interface ICreditoService
    {
        Task<CrearCreditoResponse> CrearCredito(CrearCreditoRequest r);
        Task<GetCreditoResponse> GetCredito(string id);
        Task<GetCreditosResponse> BuscarCreditos(FiltroCredito filtro);
        Task PosponerCuota(string codigoCredito, int nroCuota);
        Task<CrearPlanDePagoResponse> CrearPlanDePago(string codigoCredito, CrearPlanDePagoRequest solicitudPlan);
    }
}
