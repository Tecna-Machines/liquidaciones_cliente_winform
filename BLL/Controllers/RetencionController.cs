using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.Abstracciones;
using DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo;

namespace BLL.Controllers
{
    public class RetencionController
    {
        private readonly IRetencionesService _service;

        public RetencionController(IRetencionesService service)
        {
            _service = service;
        }

        public Task<CatalogoRetencionesResponse> GetCatalogo()
        {
            return _service.GetCatalogo();
        }
    }
}
