using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.Liquidar
{
    internal class RealizarLiquidacion
    {
        private readonly ClientApiLiquidacion _api;

        public RealizarLiquidacion(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<LiquidarResponse> Liquidar(string codigoLiquidacion)
        {
            HttpResponseMessage response = await _api.PutAsync($"Liquidacion/{codigoLiquidacion}/liquidar", null);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<LiquidarResponse>.GetBodyValue(response);
        }
    }
}
