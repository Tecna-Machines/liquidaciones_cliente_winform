using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo;

namespace DAL.Service.ApiLiquidacion.Features.RetencionesFijas.Abstracciones
{
    public interface IRetencionesService
    {
        Task<CatalogoRetencionesResponse> GetCatalogo();
    }
}
