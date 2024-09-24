﻿namespace LAUCHA.application.DTOs.RetencionesFijasDTOs
{
    public class RetencionFijaDTO
    {
        public string Codigo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public decimal Unidades { get; set; }
        public bool EsPorcentual { get; set; }
        public bool EsQuincenal { get; set; }
    }
}
