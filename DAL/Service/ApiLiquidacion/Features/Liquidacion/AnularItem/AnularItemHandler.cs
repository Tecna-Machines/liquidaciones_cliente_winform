using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.AnularItem
{
    internal class AnularItemHandler
    {
        private readonly ClientApiLiquidacion _api;

        public AnularItemHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async void CancelarItem(string codigoLiquidacion, int NroItem)
        {

            string uri = $"Liquidacion/{codigoLiquidacion}/items/{NroItem}";

            HttpResponseMessage response = await _api.PatchAsync(uri, null);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new Exception("fallo");
            }

        }
    }
}
