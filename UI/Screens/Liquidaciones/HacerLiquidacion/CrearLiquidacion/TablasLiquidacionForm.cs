using DAL.Service.Liquidacion.Features.Contrato.GetById;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;

namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    internal static class TablasLiquidacionForm
    {
        public static void SetTablaAcuerdo(GetLiquidacionByIdResponse liquidacion, ListView tablaAcuerdo)
        {
            var acuerdo = liquidacion.Acuerdo;

            var itemCodigo = new ListViewItem("codigo:");
            itemCodigo.SubItems.Add(acuerdo.Codigo);
            tablaAcuerdo.Items.Add(itemCodigo);

            var itemFecha = new ListViewItem("fecha:");
            itemFecha.SubItems.Add(acuerdo.Fecha.ToString("dd/MM/yyyy HH:mm"));
            tablaAcuerdo.Items.Add(itemFecha);

            var itemValorHora = new ListViewItem("valor hora:");
            itemValorHora.SubItems.Add(acuerdo.ValorHora.ToString("C"));
            tablaAcuerdo.Items.Add(itemValorHora);

            var itemValorBlanco = new ListViewItem("valor blanco:");
            itemValorBlanco.SubItems.Add(acuerdo.ValorBlanco.ToString("C"));
            tablaAcuerdo.Items.Add(itemValorBlanco);

            var itemValorSueldo = new ListViewItem("sueldo:");
            itemValorSueldo.SubItems.Add(acuerdo.Sueldo.ToString("C"));
            tablaAcuerdo.Items.Add(itemValorSueldo);

            var itemTipoSueldo = new ListViewItem("tipo:");
            itemTipoSueldo.SubItems.Add(acuerdo.TipoSueldo.Descripcion);
            tablaAcuerdo.Items.Add(itemTipoSueldo);

            SetAdicionales(acuerdo.Adicionales,tablaAcuerdo); 
           
        }

        private static void SetAdicionales(IEnumerable<AdicionalAcuerdoResponse> adicionales, ListView tablaAcuerdo)
        {
            var itemTitleAdicionales = new ListViewItem("ADICIONALES")
            {
                BackColor = Color.Yellow,
                Font = new Font(SystemFonts.DefaultFont, FontStyle.Bold)
            };

            tablaAcuerdo.Items.Add(itemTitleAdicionales);

            foreach (var adi in adicionales)
            {
                var itemAdicional = new ListViewItem(adi.Concepto);

                if(adi.EsPorcentual)
                {
                itemAdicional.SubItems.Add($"{adi.Monto} %");

                }
                else
                {
                  itemAdicional.SubItems.Add(adi.Monto.ToString("C"));
                }

                tablaAcuerdo.Items.Add(itemAdicional);

            }
        }
    }
}
