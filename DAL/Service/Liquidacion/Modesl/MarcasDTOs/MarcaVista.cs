namespace DAL.Service.Liquidacion.Modesl.MarcasDTOs
{
    public class MarcaVista
    {
        public string IdPersonal { get; set; } = null!;
        public string NombreCompleto { get; set; } = null!;
        public DateTime Ingreso { get; set; }
        public DateTime Egreso { get; set; }
        public TimeSpan DebeEntrar { get; set; }
        public string Tarde { get; set; } = null!;
        public decimal HsComunes { get; set; }
        public decimal HsExtra { get; set; }
        public decimal HsDoble { get; set; }
        public decimal HsTrabajadas { get; set; }

    }
}
