using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones
{
    internal class CreditoService : ICreditoService
    {
        private readonly CrearCredito _crearCredito;
        private readonly GetCreditoById _getCredito;
        private readonly GetCreditosHandler _getCreditosFiltrados;

        public CreditoService(CrearCredito crearCredito,
                              GetCreditoById getCredito,
                              GetCreditosHandler getCreditosFiltrados)
        {
            _crearCredito = crearCredito;
            _getCredito = getCredito;
            _getCreditosFiltrados = getCreditosFiltrados;
        }

        public async Task<CrearCreditoResponse> CrearCredito(CrearCreditoRequest r)
        {
            return await _crearCredito.Crear(r);
        }

        public async Task<GetCreditoResponse> GetCredito(string id)
        {
           return await _getCredito.Get(id);
        }

        public async Task<GetCreditosResponse> BuscarCreditos(FiltroCredito filtro)
        {
            return await _getCreditosFiltrados.BuscarCreditos(filtro);
        }
    }
}
