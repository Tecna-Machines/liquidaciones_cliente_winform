using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class ConfirmarLiquidacion
    {
        private readonly ClienteLiq Client;

        public ConfirmarLiquidacion(ClienteLiq client)
        {
            Client = client;
        }

        public async Task<LiquidacionDTO> CompletarLiquidacion(string dniEmp, PeriodoDTO periodo)
        {
            string fechaInicio = periodo.Inicio.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
            string fechaFin = periodo.Fin.ToString("s", System.Globalization.CultureInfo.InvariantCulture);

            string endpoint = $"Liquidacion/empleado/{dniEmp}/liquidar?desde={fechaInicio}&hasta={fechaFin}";
            HttpResponseMessage response = await Client.PostAsync(endpoint, null);

            if (!response.IsSuccessStatusCode)
            {
                throw new IOException();
            }

            string responseBody = await response.Content.ReadAsStringAsync();

            var liquidacion = JsonSerializer.Deserialize<LiquidacionDTO>(responseBody, Client.GetJsonOptions());

            return liquidacion ?? throw new ArgumentNullException();
        }
    }
}
