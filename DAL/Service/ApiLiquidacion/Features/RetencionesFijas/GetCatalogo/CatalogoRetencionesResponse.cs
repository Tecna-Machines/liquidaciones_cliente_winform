namespace DAL.Service.ApiLiquidacion.Features.RetencionesFijas.GetCatalogo
{
    public sealed record CatalogoRetencionesResponse(int Total, IEnumerable<CatalogoRetencionResponse> Items);

    public sealed record CatalogoRetencionResponse(string Codigo
                                           , string Concepto,
                                            decimal Unidades,
                                            bool EsPorcentual,
                                            bool EsPrimeraQuincena);
}
