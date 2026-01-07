using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones
{
    public interface ICreditoService
    {
        Task<CrearCreditoResponse> CrearCredito(CrearCreditoRequest r);
    }
}
