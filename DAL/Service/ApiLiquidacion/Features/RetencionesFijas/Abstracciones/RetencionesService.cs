using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo;

namespace DAL.Service.ApiLiquidacion.Features.RetencionesFijas.Abstracciones
{
    internal class RetencionesService : IRetencionesService
    {
        private readonly GetRetenciones _getCatalogo;

        public RetencionesService(GetRetenciones getCatalogo)
        {
            _getCatalogo = getCatalogo;
        }

        public Task<CatalogoRetencionesResponse> GetCatalogo()
        {
            return _getCatalogo.GetCatalogo();
        }
    }
}
