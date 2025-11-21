using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class DescargarRecibo
    {
        private readonly ClientApiLiquidacion _httpClient;

        public DescargarRecibo(ClientApiLiquidacion httpClient)
        {
            this._httpClient = httpClient;
        }

        public async Task<byte[]> DescargarReciboAsync(string codigoLiqudacion)
        {
            HttpResponseMessage response = await _httpClient.GetAsync($"Liquidacion/{codigoLiqudacion}/recibo");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadAsByteArrayAsync();
        }

    }
}
