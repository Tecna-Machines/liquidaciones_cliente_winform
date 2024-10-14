using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ModalidadDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class RecuperarModalidades
    {
        private readonly ClienteLiq _client;

        public RecuperarModalidades(ClienteLiq httpClient)
        {
            _client = httpClient;
        }

        public async Task<List<ModalidadDTO>> recuperarModalidades()
        {
            HttpResponseMessage response = await _client.GetAsync("Modalidad");

            if (!response.IsSuccessStatusCode)
            {
                throw new IOException();
            }

            string responseBody = await response.Content.ReadAsStringAsync();
            List<ModalidadDTO>? modalidades = JsonSerializer.Deserialize<List<ModalidadDTO>>(responseBody, _client.GetJsonOptions());

            return modalidades ?? throw new NullReferenceException();
        }
    }
}
