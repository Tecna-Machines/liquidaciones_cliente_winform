using DAL.Service.Liquidacion.Http;

namespace DAL.Service.Liquidacion.Features.Contrato.GetById
{
    internal class GetAcuerdoById
    {
        private readonly ApiLiquidacion _api;

        public GetAcuerdoById(ApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetAcuerdoByIdResponse> GetById(string id)
        {
            HttpResponseMessage response = await _api.GetAsync($"Acuerdo/{id}");
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<GetAcuerdoByIdResponse>.GetBodyValue(response);
        }
    }
}
