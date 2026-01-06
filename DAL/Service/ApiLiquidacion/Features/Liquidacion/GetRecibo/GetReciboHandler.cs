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

        public async Task<byte[]> GetRecibos(int quincena, int mes, int anio)
        {
            HttpResponseMessage response = await _api.
                                                GetAsync($"Recibos?Quincena={quincena}&Mes={mes}&Anio={anio}");


            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadAsByteArrayAsync();
        }
    }
}
