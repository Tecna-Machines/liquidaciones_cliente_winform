using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    internal static class TablaDetalleLiquidacionForm
    {
        public static void SetTablaDetalleEnBlanco(GetLiquidacionByIdResponse liq, ListView tablaDetalle)
        {
            var itemsEnBlanco = liq.Items.Where(it => it.EsEnBlanco);

            foreach (var it in itemsEnBlanco)
            {
                var item = new ListViewItem(it.Concepto);

                string colRetencion = "";
                string colRemunerativo = "";
                string colNoRemunerativo = "";

                switch ((TipoItemLiquidacion)it.TipoItem)
                {
                    case TipoItemLiquidacion.Retencion:
                        colRetencion = "-" + it.Monto.ToString("C2");
                        break;

                    case TipoItemLiquidacion.Remunerativo:
                        colRemunerativo = it.Monto.ToString("C2");
                        break;

                    case TipoItemLiquidacion.NoRemunerativo:
                        colNoRemunerativo = it.Monto.ToString("C2");
                        break;
                }

                item.SubItems.Add(colRetencion);
                item.SubItems.Add(colRemunerativo);
                item.SubItems.Add(colNoRemunerativo);

                item.SubItems.Add(it.Fecha.ToString("dd/MM/yyyy"));

                tablaDetalle.Items.Add(item);
            }
        }

        public static void SetTablaDetalleEnNegro(GetLiquidacionByIdResponse liq, ListView tablaNegro)
        {
            var itemsNegro = liq.Items.Where(it => !it.EsEnBlanco);

            foreach (var it in itemsNegro)
            {
                var item = new ListViewItem(it.Concepto);

                string colRemunerativo = "";
                string colDescuento = "";

                switch ((TipoItemLiquidacion)it.TipoItem)
                {
                    case TipoItemLiquidacion.Remunerativo:
                        colRemunerativo = it.Monto.ToString("C2");
                        break;

                    case TipoItemLiquidacion.Descuento:
                        colDescuento = "-" + it.Monto.ToString("C2");
                        break;
                }

                item.SubItems.Add(colRemunerativo);
                item.SubItems.Add(colDescuento);

                item.SubItems.Add(it.Fecha.ToString("dd/MM/yyyy"));

                tablaNegro.Items.Add(item);
            }


        }



    }

    public enum TipoItemLiquidacion
    {
        Remunerativo,
        Descuento,
        NoRemunerativo,
        Retencion
    }
}
