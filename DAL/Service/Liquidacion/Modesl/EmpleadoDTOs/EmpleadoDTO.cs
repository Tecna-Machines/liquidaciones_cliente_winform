﻿namespace LAUCHA.application.DTOs.EmpleadoDTO
{
    public class EmpleadoDTO : CrearEmpleadoDTO
    {
        public string NumeroCuenta { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public bool EstadoCuenta { get; set; }
    }
}
