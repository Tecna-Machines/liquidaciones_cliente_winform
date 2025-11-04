namespace DAL.Service.Liquidacion.UseCase.Empleados.Crear
{
    public class EmpleadoResponse 
    {
        public string Dni { get; set; } = "";
       public string Nombre { get; set; } = "";
        public string Apellido { get; set; } = "";
       public DateTime FechaIngreso { get; set; }
       public DateTime FechaNacimiento { get; set; }
       public DateTime FechaAlta { get; set; }
        public string NumeroCuenta { get; set; } = null!;
        public DateTime FechaCreacion { get; set; }
        public bool EstadoCuenta { get; set; }
        public ContratoResumenDTO ContratoResumen { get; set; } = null!;
    }

    public class ContratoResumenDTO
    {
        public string CodigoContrato { get; set; } = null!;
        public string CodigoModalidad { get; set; } = null!;
        public string DescripcionModalidad { get; set; } = null!;
    }
}
