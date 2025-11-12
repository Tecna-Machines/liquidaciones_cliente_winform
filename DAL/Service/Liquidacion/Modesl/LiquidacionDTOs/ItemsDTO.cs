using LAUCHA.application.DTOs.DescuentoDTOs;
using LAUCHA.application.DTOs.NoRemuneracionDTOs;
using LAUCHA.application.DTOs.RemuneracionDTOs;

namespace LAUCHA.application.DTOs.LiquidacionDTOs
{
    public class ItemsDTO
    {
        public List<RemuneracionDTO> Remuneraciones { get; set; } = null!;
        public List<RetencionDTOs.RetencionDTO> Retenciones { get; set; } = null!;
        public List<DescuentoDTO> Descuentos { get; set; } = null!;
        public List<NoRemuneracionDTO> NoRemuneraciones { get; set; } = null!;
    }
}
