namespace DAL.Service.ApiLiquidacion.Features.Creditos.GetCreditos
{
    public record GetCreditosResponse(IEnumerable<GetCreditoResumen> Creditos);

    public record GetCreditoResumen(string Codigo,
                                    string DniEmpleado,
                                    int Cuotas,
                                    string Descripcion,
                                    decimal MontoPrestado,
                                    string Estado);

    public sealed record FiltroCredito
    {
        public string? Dni { get; init; }
        public int? Estado { get; init; }

        public decimal? MontoMin { get; init; }
        public decimal? MontoMax { get; init; }

        public DateTime? CreacionDesde { get; init; }
        public DateTime? CreacionHasta { get; init; }
    }
}
