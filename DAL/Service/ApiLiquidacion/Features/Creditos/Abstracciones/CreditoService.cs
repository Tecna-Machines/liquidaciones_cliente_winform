using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones
{
    internal class CreditoService : ICreditoService
    {
        private readonly CrearCredito _crearCredito;

        public CreditoService(CrearCredito crearCredito)
        {
            _crearCredito = crearCredito;
        }

        public async Task<CrearCreditoResponse> CrearCredito(CrearCreditoRequest r)
        {
            return await _crearCredito.Crear(r);
        }
    }
}
