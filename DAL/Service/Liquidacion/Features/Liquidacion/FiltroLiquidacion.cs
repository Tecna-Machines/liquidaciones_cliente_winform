namespace DAL.Service.Liquidacion.UseCase.Liquidacion
{
    public class FiltroLiquidacion
    {
        public string? dniEmp { get; set; }
        public DateTime? fechaLiquidacion { get; set; }
        public DateTime? inicioPeriodo { get; set; }
        public DateTime? finPeriodo { get; set; }
        public string? codigoLiquidacion { get; set; }
        public int cantidadRegistros { get; set; } = 10;
        public int index { get; set; } = 1;
        public bool orden { get; set; }
    }
}

