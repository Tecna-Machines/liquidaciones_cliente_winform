using DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas;

namespace DAL.Service.ApiLiquidacion.Features.CuentasContables.Abstracciones
{
    public interface ICuentasContablesService
    {
        Task<IEnumerable<CuentaContableResponse>> GetCuentasContables();
    }
}
