using DAL.Service.ApiLiquidacion.Features.CuentasContables.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas;

namespace BLL.Controllers
{
    public class CuentasContablesController
    {
        private readonly ICuentasContablesService _cuentasService;

        public CuentasContablesController(ICuentasContablesService cuentasService)
        {
            _cuentasService = cuentasService;
        }

        public async Task<IEnumerable<CuentaContableResponse>> ObtenerCuentas()
        {
            return await _cuentasService.GetCuentasContables();
        }
    }
}
