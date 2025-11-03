using DAL.Service.Liquidacion.Http;
using LAUCHA.application.DTOs.ModalidadDTOs;
using System.Text.Json;

namespace DAL.Service.Liquidacion.UseCase.Contrato
{
    public class RecuperarModalidades
    {
        private readonly ApiLiquidacion _client;

        public RecuperarModalidades(ApiLiquidacion httpClient)
        {
            _client = httpClient;
        }

        public async Task<List<ModalidadDTO>> recuperarModalidades()
        {
            //HttpResponseMessage response = await _client.GetAsync("Modalidad");

            //if (!response.IsSuccessStatusCode)
            //{
            //    throw new IOException();
            //}

            //string responseBody = await response.Content.ReadAsStringAsync();
            //List<ModalidadDTO>? modalidades = JsonSerializer.Deserialize<List<ModalidadDTO>>(responseBody, _client.GetJsonOptions());

            //return modalidades ?? throw new NullReferenceException();

            var Mensual = new ModalidadDTO { Codigo = "10",Descripcion= "mensual"};
            var MensualFijoMasExtra = new ModalidadDTO {Codigo= "12",Descripcion="mensual fijo mas extra" };
            var QuincenalHora = new ModalidadDTO { Codigo= "20",Descripcion="quincenal hora"};
            var QuincenalFijo = new ModalidadDTO { Codigo="22",Descripcion="quincenal fijo"};

            return new List<ModalidadDTO> { Mensual,MensualFijoMasExtra,QuincenalFijo,QuincenalHora};
        }
    }
}
