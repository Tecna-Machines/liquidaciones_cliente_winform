using BLL.Controllers;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using UI.Utils;

namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    public partial class AnularItemForm : Form
    {
        private readonly LiquidacionController _liquidacion;
        private ItemLiquidacionByIdResponse? _item;
        private string? _idLiquidacion;
        public AnularItemForm(LiquidacionController liquidacion)
        {
            InitializeComponent();
            _liquidacion = liquidacion;
        }

        public void SetItem(string idLiquidacion, ItemLiquidacionByIdResponse item)
        {
            _idLiquidacion = idLiquidacion;
            _item = item;

            textBoxConcepto.Text = item.Concepto;
            textBoxMonto.Text = item.Monto.ToString("C2");
            textBoxFecha.Text = item.Fecha.ToString("dd/MM/yyyy HH:mm");

            if (item.EsAutomatico)
            {
                BtnAnular.Enabled = false;
                textBoxEsAutomatico.Text = "los items generados por el sistema no pueden ser borrados";
            }
            else
            {
                BtnAnular.Enabled = true;
                textBoxEsAutomatico.Text = "este item puede anularse";
            }
        }

        public void AnularItem(string id, int NroItem)
        {
            _liquidacion.BorrarItemDeLiquidacion(id, NroItem);
        }

        private void BtnAnular_Click(object sender, EventArgs e)
        {
            if (_item!.EsAutomatico)
            {
                Dialog.Error("no se puede");
                return;
            }

            try
            {
                AnularItem(_idLiquidacion!, _item!.Nro);
            }
            catch (Exception ex)
            {
                Dialog.Error($"error.anular.item : {ex.Message}");
                return;
            }

            Dialog.Success("se elimino el item");
            this.Close();
            return;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
