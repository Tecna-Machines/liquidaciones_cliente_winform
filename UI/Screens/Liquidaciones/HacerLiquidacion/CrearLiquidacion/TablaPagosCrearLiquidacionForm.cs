using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    internal static class TablaPagosCrearLiquidacionForm
    {
        public static void SetTablaPagos(GetLiquidacionByIdResponse liq, ListView lvPagos)
        {
            var pagos = liq.Pagos;

            foreach (var pago in pagos)
            {
                ListViewItem item = new(pago.Monto.ToString("C"));
                item.Tag = pago;
                item.SubItems.Add(pago.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(pago.ReferenciaContable);

                lvPagos.Items.Add(item);
            }
        }
    }
}
