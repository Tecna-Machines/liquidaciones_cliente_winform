using BLL.Controllers;
using UI.Utils;

namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    public partial class SellarLiquidacionForm : Form
    {
        private string _codigoLiquidacion;
        private LiquidacionController _liquidacionController;

        public SellarLiquidacionForm(LiquidacionController liquidacionController)
        {
            InitializeComponent();

            _codigoLiquidacion = string.Empty;
            _liquidacionController = liquidacionController;
        }

        public void SetCodigoLiquidacion(string id)
        {
            _codigoLiquidacion = id;
        }

        private async void BtnOk_Click(object sender, EventArgs e)
        {
            var result = await _liquidacionController.SellarLiquidacion(_codigoLiquidacion);

            Dialog.Success($"LIQUIDACION SELLADA");

            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
