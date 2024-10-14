using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.RetencionesFijasDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.RetencionesFijas
{
    public class ObtenerRetencionesFijas
    {
        private readonly ClienteLiq _cliente;

        public ObtenerRetencionesFijas(ClienteLiq cliente)
        {
            _cliente = cliente;
        }

        public async Task<List<RetencionFijaDTO>> ObtenerListaRetencionesFijas()
        {
            HttpResponseMessage response = await _cliente.GetAsync("RetencionFija");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            List<RetencionFijaDTO>? lista = JsonSerializer.Deserialize<List<RetencionFijaDTO>>(responseBody, _cliente.GetJsonOptions());

            return lista ?? throw new NullReferenceException();
        }
    }
}
