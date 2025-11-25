using DAL.Service.Liquidacion.Http;
using System.Text.Json;

namespace DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo
{
    public class GetRetenciones
    {
        private readonly ClientApiLiquidacion _cliente;

        public GetRetenciones(ClientApiLiquidacion cliente)
        {
            _cliente = cliente;
        }

        public async Task<CatalogoRetencionesResponse> GetCatalogo()
        {
            HttpResponseMessage response = await _cliente.GetAsync("Retencion");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            var catalogo = await GetJsonValue<CatalogoRetencionesResponse>.GetBodyValue(response);

            return catalogo ?? throw new NullReferenceException();
        }
    }
}
