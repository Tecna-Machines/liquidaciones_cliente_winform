namespace DAL.Service.ApiLiquidacion.Features.Liquidacion.Pagar
{
    public record CrearPagoRequest(string LiquidacionId,
                                   string CuentaContableId,
                                   decimal Monto,
                                   int Modo,
                                   string Descripcion);

    public record PagoCreadoResponse(string Id,
                                    string Descripcion,
                                    decimal Monto);
}
