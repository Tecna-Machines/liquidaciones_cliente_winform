using DAL.Service.ApiLiquidacion.Features.Creditos.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.Creditos.Crear;
using DAL.Service.ApiLiquidacion.Features.Creditos.CrearPlanPago;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos;

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

        public Task<GetCreditoResponse> GetCredito(string id)
        {
            return _creditos.GetCredito(id);
        }

        public Task<GetCreditosResponse> Buscar(FiltroCredito filtro)
        {
            return _creditos.BuscarCreditos(filtro);
        }

        public async Task PosponerCuotas(string codigoCredito,int nroCuota)
        {
            await _creditos.PosponerCuota(codigoCredito, nroCuota);
        }

        public async Task<CrearPlanDePagoResponse> CrearPlanDePago(string codigoCredito,CrearPlanDePagoRequest plan)
        {
            return await _creditos.CrearPlanDePago(codigoCredito, plan);
        }
    }
}
