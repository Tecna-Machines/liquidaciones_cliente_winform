using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    internal static class TablaPagosLiquidacionForm
    {
        public static void SetTablaPagos(GetLiquidacionByIdResponse liq, ListView tablaPagos)
        {
            var pagos = liq.Pagos;

            foreach (var p in pagos)
            {
                var item = new ListViewItem(p.Id);

                item.SubItems.Add(p.Monto.ToString("C")); //monto, fecha ,descripcion
                item.SubItems.Add(p.Fecha.ToString("dd/MM/yyyy HH:ss"));
                item.SubItems.Add(p.Descripcion);
                item.SubItems.Add(p.Modo);


                tablaPagos.Items.Add(item);
            }

        }
    }
}
