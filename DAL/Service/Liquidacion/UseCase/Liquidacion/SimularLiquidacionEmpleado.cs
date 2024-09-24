using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class SimularLiquidacionEmpleado
    {
        private readonly ClienteLiq Client;

        public SimularLiquidacionEmpleado(ClienteLiq client)
        {
            Client = client;
        }

        public async Task<LiquidacionDTO> SimularLiquidacion(string dniEmp,PeriodoDTO periodo)
        {
            string fechaInicio = periodo.Inicio.ToString("s", System.Globalization.CultureInfo.InvariantCulture);
            string fechaFin = periodo.Fin.ToString("s", System.Globalization.CultureInfo.InvariantCulture);

            string endpoint = $"Liquidacion/empleado/{dniEmp}/simular?desde={fechaInicio}&hasta={fechaFin}";
            HttpResponseMessage response = await Client.PostAsync(endpoint,null);

            if(!response.IsSuccessStatusCode)
            {
                throw new IOException();
            }

            string responseBody = await response.Content.ReadAsStringAsync();

            var liquidacion = JsonSerializer.Deserialize<LiquidacionDTO>(responseBody, Client.GetJsonOptions());

            return liquidacion ?? throw new ArgumentNullException();
        }
    }
}
