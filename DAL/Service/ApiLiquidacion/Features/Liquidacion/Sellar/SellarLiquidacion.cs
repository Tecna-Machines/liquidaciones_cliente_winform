using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.Sellar
{
    internal class SellarLiquidacion
    {
        private readonly ClientApiLiquidacion _api;

        public SellarLiquidacion(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<SellarLiquidacionResponse> Sellar(string codigo)
        {
            HttpResponseMessage response = await _api.PutAsync($"Liquidacion/{codigo}/sellar", null);

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<SellarLiquidacionResponse>.GetBodyValue(response);
        }
    }
}
