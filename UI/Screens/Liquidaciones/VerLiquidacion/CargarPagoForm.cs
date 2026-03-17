using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Pagar;
using UI.Screens.VerLiquidacion;

namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    public partial class CargarPagosForm : Form
    {
        private readonly CuentasContablesController _cuentasController;
        private readonly LiquidacionController _liquidacionController;

        private  VerLiquidacionForm? _formPadreLiquidacion;

        private string? _liquidacionId;
        public CargarPagosForm(CuentasContablesController cuentasController,
                              LiquidacionController liquidacionController)
        {
            InitializeComponent();
            _cuentasController = cuentasController;
            _liquidacionController = liquidacionController;
        }

        public void SetFormPadre(VerLiquidacionForm padre)
        {
            _formPadreLiquidacion = padre;
        }
        public void SetLiquidacion(string liquidacionId)
        {
            _liquidacionId = liquidacionId;
        }
        private void TextBoxMonto_TextChanged(object sender, EventArgs e)
        {
            string montoStr = textBoxMonto.Text;
            decimal monto;

            decimal.TryParse(montoStr, out monto);

            textBoxMontoContab.Text = monto.ToString("C");
        }

        private async void CargarPagosForm_Load(object sender, EventArgs e)
        {
            var cuentas = await _cuentasController.ObtenerCuentas();

            comboBoxCuentasContables.DataSource = cuentas.ToList();

        }

        private async void BtnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                var cuenta = (CuentaContableResponse)comboBoxCuentasContables.SelectedItem;

                string liquidacionId = _liquidacionId
                    ?? throw new ArgumentException("falta.liquidacion");

                string cuentaContableId = cuenta.Id;

                decimal monto = decimal.Parse(textBoxMonto.Text);
                int modo = radioButtonTransferencia.Checked ? 1 : 0;
                string descripcion = textBoxDescripcion.Text;

                var crearPago = new CrearPagoRequest(
                    liquidacionId,
                    cuentaContableId,
                    monto,
                    modo,
                    descripcion
                );

                await _liquidacionController.PagarLiquidacion(crearPago);

                MessageBox.Show("Pago registrado correctamente");

                await RefrescarFormularioLiquidacion(liquidacionId);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private async Task RefrescarFormularioLiquidacion(string liquidacionId)
        {
            if(_formPadreLiquidacion is null)
            {
                return;
            }

            var liq = await _liquidacionController.GetById(liquidacionId);

            _formPadreLiquidacion.SetLiquidacion(liq ?? throw new Exception("liq.null"));

            this.Close();
        }
    }
}
