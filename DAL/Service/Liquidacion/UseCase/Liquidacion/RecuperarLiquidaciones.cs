using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using LAUCHA.application.DTOs.PaginaDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class RecuperarLiquidaciones
    {
        private readonly ClienteLiq _httpClient;

        public RecuperarLiquidaciones(ClienteLiq httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PaginaDTO<LiquidacionResumenDTO>> RecuperarLiquidacionesFiltradas(FiltroLiquidacion filtro)
        {
            //endpoint /Liquidacion
            var queryParams = new List<string>();

            if (!string.IsNullOrEmpty(filtro.dniEmp))
            {
                queryParams.Add($"dniEmp={Uri.EscapeDataString(filtro.dniEmp)}");
            }

            if (filtro.fechaLiquidacion.HasValue)
            {
                queryParams.Add($"fechaLiquidacion={filtro.fechaLiquidacion.Value:yyyy-MM-dd}");
            }

            if (filtro.inicioPeriodo.HasValue)
            {
                queryParams.Add($"inicioPeriodo={filtro.inicioPeriodo.Value:yyyy-MM-dd}");
            }

            if (filtro.finPeriodo.HasValue)
            {
                queryParams.Add($"finPeriodo={filtro.finPeriodo.Value:yyyy-MM-dd}");
            }

            if (!string.IsNullOrEmpty(filtro.codigoLiquidacion))
            {
                queryParams.Add($"codigoLiquidacion={Uri.EscapeDataString(filtro.codigoLiquidacion)}");
            }

            queryParams.Add($"cantidad={filtro.cantidadRegistros}");
            queryParams.Add($"index={filtro.index}");
            queryParams.Add($"orden={filtro.orden}");

            var queryString = string.Join("&", queryParams);
            var endpoint = $"Liquidacion?{queryString}";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

            string responseBody = await response.Content.ReadAsStringAsync();

            var pagina = JsonSerializer.Deserialize<PaginaDTO<LiquidacionResumenDTO>>(responseBody, _httpClient.GetJsonOptions());
            return pagina ?? new PaginaDTO<LiquidacionResumenDTO>();

        }

        public async Task<LiquidacionDTO> RecuperarLiquidacion(string codigoLiquidacion)
        {
            string endpoint = $"Liquidacion/{codigoLiquidacion}";

            HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
            string responseBody = await response.Content.ReadAsStringAsync();

            var liquidacion = JsonSerializer.Deserialize<LiquidacionDTO>(responseBody, _httpClient.GetJsonOptions());
            return liquidacion;
        }
    }
}
