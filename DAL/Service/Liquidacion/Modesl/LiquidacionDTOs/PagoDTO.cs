﻿namespace LAUCHA.application.DTOs.LiquidacionDTOs
{
    public class PagoDTO
    {
        public int codigo { get; set; }
        public string Fecha { get; set; } = null!;
        public decimal Monto { get; set; }
    }
}
