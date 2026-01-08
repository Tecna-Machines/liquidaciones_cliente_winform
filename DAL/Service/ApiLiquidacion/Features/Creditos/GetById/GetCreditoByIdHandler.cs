using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.GetById
{
    internal class GetCreditoByIdHandler
    {
        private readonly ClientApiLiquidacion _api;

        public GetCreditoByIdHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetCreditoResponse> Get(string id)
        {

            HttpResponseMessage response = await _api.GetAsync($"Credito/{id}");
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("not.found");
            }

            return await GetJsonValue<GetCreditoResponse>.GetBodyValue(response);
        }
    }
}
