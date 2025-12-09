using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.GetRecibo
{
    internal class GetReciboHandler
    {
        private readonly ClientApiLiquidacion _api;

        public GetReciboHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<byte[]> GetRecibo(string liq)
        {
            HttpResponseMessage response = await _api.GetAsync($"Liquidacion/{liq}/recibo");


            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
