using DAL.Service.Liquidacion.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos
{
    internal class GetCreditosHandler
    {
        private readonly ClientApiLiquidacion _api;

        public GetCreditosHandler(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetCreditosResponse> BuscarCreditos(FiltroCredito filtro)
        {
            var url = CrearUrlConQueryCreditos(filtro);

            HttpResponseMessage response = await _api.GetAsync(url);
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("not.found");
            }

            return await GetJsonValue<GetCreditosResponse>.GetBodyValue(response);
        }

        private static string CrearUrlConQueryCreditos(FiltroCredito filtro)
        {
            const string path = "Credito";

            var query = new Dictionary<string, string?>();

            if (!string.IsNullOrWhiteSpace(filtro.Dni))
                query["dni"] = filtro.Dni.Trim();

            if (filtro.Estado.HasValue)
                query["estado"] = filtro.Estado.Value.ToString();

            if (filtro.MontoMin.HasValue)
                query["montoMin"] = filtro.MontoMin.Value.ToString();

            if (filtro.MontoMax.HasValue)
                query["montoMax"] = filtro.MontoMax.Value.ToString();

            if (filtro.CreacionDesde.HasValue)
                query["creacionDesde"] = filtro.CreacionDesde.Value.ToString("yyyy-MM-dd");

            if (filtro.CreacionHasta.HasValue)
                query["creacionHasta"] = filtro.CreacionHasta.Value.ToString("yyyy-MM-dd");

            // Si no hay filtros, devuelve solo el path
            return query.Count == 0
                ? path
                : QueryHelpers.AddQueryString(path, query);
        }


    }
}
