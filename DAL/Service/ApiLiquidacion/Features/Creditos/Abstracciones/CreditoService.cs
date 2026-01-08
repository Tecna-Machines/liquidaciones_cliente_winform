using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.ApiLiquidacion.Features.Creditos.Cuotas.PosponerCuota;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones
{
    internal class CreditoService : ICreditoService
    {
        private readonly CrearCredito _crearCredito;
        private readonly GetCreditoByIdHandler _getCredito;
        private readonly GetCreditosHandler _getCreditosFiltrados;
        private readonly PosponerCuotaHandler _posponerCuota;

        public CreditoService(CrearCredito crearCredito,
                              GetCreditoByIdHandler getCredito,
                              GetCreditosHandler getCreditosFiltrados,
                              PosponerCuotaHandler posponerCuota)
        {
            _crearCredito = crearCredito;
            _getCredito = getCredito;
            _getCreditosFiltrados = getCreditosFiltrados;
            _posponerCuota = posponerCuota;
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

        public async Task PosponerCuota(string codigoCredito,int nroCuota)
        {
           await _posponerCuota.Posponer(new PosponerCuotaRequest(codigoCredito, nroCuota));
        }
    }
}
