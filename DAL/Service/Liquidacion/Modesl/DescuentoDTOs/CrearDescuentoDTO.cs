﻿namespace LAUCHA.application.DTOs.DescuentoDTOs
{
    public class CrearDescuentoDTO
    {
        public string Descripcion { get; set; } = null!;
        public decimal Monto { get; set; }
        public int? NumeroConcepto { get; set; }
        public string NumeroCuenta { get; set; } = null!;
    }
}
