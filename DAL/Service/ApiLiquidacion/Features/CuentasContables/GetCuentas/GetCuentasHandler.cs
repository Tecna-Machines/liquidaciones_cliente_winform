using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas
{
    internal class GetCuentasHandler
    {
        private readonly ClientApiLiquidacion _api;

        public GetCuentasHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<IEnumerable<CuentaContableResponse>> GetCuentas()
        {

            HttpResponseMessage response = await _api.GetAsync($"cuentas-contables");

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new Exception("algo.exploto");
            }

            return await GetJsonValue<IEnumerable<CuentaContableResponse>>.GetBodyValue(response);
        }
    }
}
