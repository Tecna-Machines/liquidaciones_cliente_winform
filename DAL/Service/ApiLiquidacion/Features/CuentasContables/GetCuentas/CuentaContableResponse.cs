namespace DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas
{
    public record CuentaContableResponse(string Id,
                                         string Nombre,
                                         string Tipo)
    {
        public override string ToString()
        => $"{Id} : {Nombre}";
    }
}
