using DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas;

namespace DAL.Service.ApiLiquidacion.Features.CuentasContables.Abstracciones
{
    internal class CuentasContablesService : ICuentasContablesService
    {
        private readonly GetCuentasHandler _cuentas;

        public CuentasContablesService(GetCuentasHandler cuentas)
        {
            _cuentas = cuentas;
        }

        public async Task<IEnumerable<CuentaContableResponse>> GetCuentasContables()
        {
            return await _cuentas.GetCuentas();
        }
    }
}
