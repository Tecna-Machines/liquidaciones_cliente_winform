namespace DAL.Service.ApiLiquidacion.Features.Creditos.CrearPlanPago
{
    public record CrearPlanDePagoRequest(int QuincenaInicio,
                                      int MesInicio,
                                      int AnioInicio,
                                      int CantCuotas);

    public record CrearPlanDePagoResponse(string CodigoCredito);
}
