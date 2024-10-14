using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.DescuentoDTOs;
using System.Net.Http.Json;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.AgregarItems
{
    public class AgregarDescuento
    {
        private readonly ClienteLiq _client;

        public AgregarDescuento(ClienteLiq client)
        {
            _client = client;
        }

        public async Task<DescuentoDTO> CrearDescuento(CrearDescuentoDTO descuento)
        {
            HttpContent data = JsonContent.Create(descuento);
            HttpResponseMessage response = await _client.PostAsync("Descuento", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();



            DescuentoDTO? desc = JsonSerializer.Deserialize<DescuentoDTO>(responseBody, _client.GetJsonOptions());

            return desc ?? throw new NullReferenceException();
        }
    }


}
