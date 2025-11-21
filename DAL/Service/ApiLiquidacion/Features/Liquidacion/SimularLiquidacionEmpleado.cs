using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class SimularLiquidacionEmpleado
    {
        private readonly ClientApiLiquidacion Client;

        public SimularLiquidacionEmpleado(ClientApiLiquidacion client)
        {
            Client = client;
        }

        public async Task<LiquidacionDTO> SimularLiquidacion(string dniEmp, Quincena periodo)
        {
            string fechaInicio = periodo.Inicio.ToString("yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);
            string fechaFin = periodo.Fin.ToString("yyyy-MM-ddTHH:mm:ssZ", System.Globalization.CultureInfo.InvariantCulture);

            string endpoint = $"Liquidacion/empleado/{dniEmp}/simular?desde={fechaInicio}&hasta={fechaFin}";
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
