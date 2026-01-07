using DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;

namespace BLL.Controllers
{
    public class CreditoController
    {
        private readonly ICreditoService _creditos;

        public CreditoController(ICreditoService creditos)
        {
            _creditos = creditos;
        }

        public Task<CrearCreditoResponse> Crear(CrearCreditoRequest r)
        {
            return _creditos.CrearCredito(r);
        }
    }
}
