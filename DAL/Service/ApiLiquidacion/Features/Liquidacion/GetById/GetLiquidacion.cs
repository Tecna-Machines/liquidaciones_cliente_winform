using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.Features.Liquidacion.GetById
{
    internal class GetLiquidacion
    {
        private readonly ClientApiLiquidacion _api;

        public GetLiquidacion(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetLiquidacionByIdResponse> Get(string codigo)
        {

            HttpResponseMessage response = await _api.GetAsync($"Liquidaciones/{codigo}");

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<GetLiquidacionByIdResponse>.GetBodyValue(response);
        }
    }
}
