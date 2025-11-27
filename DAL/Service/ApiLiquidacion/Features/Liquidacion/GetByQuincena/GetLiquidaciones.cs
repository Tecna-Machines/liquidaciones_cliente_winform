using DAL.Service.Liquidacion.Http;

namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.GetByQuincena
{
    internal class GetLiquidaciones
    {
        private readonly ClientApiLiquidacion _api;

        public GetLiquidaciones(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetLiquidacionesResponse> GetByQuincena(int quincena, int mes, int anio)
        {
            HttpResponseMessage response = await _api.GetAsync($"Liquidacion?quincena={quincena}&mes={mes}&anio={anio}");

            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("no se recuperaron");
            }

            return await GetJsonValue<GetLiquidacionesResponse>.GetBodyValue(response);
        }
    }
}
