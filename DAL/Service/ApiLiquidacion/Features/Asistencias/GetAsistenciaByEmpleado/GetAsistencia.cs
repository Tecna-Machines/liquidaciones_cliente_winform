using DAL.Service.Liquidacion.Http;
using Microsoft.AspNetCore.WebUtilities;

namespace DAL.Service.ApiLiquidacion.Features.Asistencias.GetAsistenciaByEmpleado
{
    internal class GetAsistencia
    {
        private readonly ClientApiLiquidacion _api;

        public GetAsistencia(ClientApiLiquidacion api)
        {
            _api = api;
        }

        public async Task<GetEmpleadoAsistenciasResponse> GetAsistencias(string dni, DateTime inicio, DateTime fin)
        {
            var url = GenerarUrl(dni, inicio, fin);

            HttpResponseMessage response = await _api.GetAsync(url);
            int statusCode = await GetHttpStatusCode.GetCode(response);

            if (statusCode != 200)
            {
                throw new ArgumentException("not.found");
            }

            return await GetJsonValue<GetEmpleadoAsistenciasResponse>.GetBodyValue(response);
        }

        private string GenerarUrl(string dni, DateTime inicio, DateTime fin)
        {
            string path = $"empleado/{dni}/asistencias";

            var query = new Dictionary<string, string?>();

            query["inicio"] = inicio.ToString("yyyy-MM-dd");

            query["fin"] = fin.ToString("yyyy-MM-dd");

            return query.Count == 0
                ? path
                : QueryHelpers.AddQueryString(path, query);
        }
    }
}
