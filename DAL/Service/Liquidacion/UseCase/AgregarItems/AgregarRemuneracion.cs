using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.RemuneracionDTOs;
using LAUCHA.application.DTOs.RetencionDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.AgregarItems
{
    public class AgregarRemuneracion
    {
        private readonly ClienteLiq _client;

        public AgregarRemuneracion(ClienteLiq client)
        {
            _client = client;
        }

        public async Task<RemuneracionDTO> CrearRemuneracionD(CrearRemuneracionDTO remuneracion)
        {
            HttpContent data = JsonContent.Create(remuneracion);
            HttpResponseMessage response = await _client.PostAsync("Remuneracion", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            RemuneracionDTO? remu = JsonSerializer.Deserialize<RemuneracionDTO>(responseBody, _client.GetJsonOptions());

            return remu ?? throw new NullReferenceException();
        }
    }
}
