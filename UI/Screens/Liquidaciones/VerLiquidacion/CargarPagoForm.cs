using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.CuentasContables.GetCuentas;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.Pagar;
using UI.Screens.VerLiquidacion;

namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    public partial class CargarPagosForm : Form
    {
        private readonly LiquidacionController _liquidacionController;

        private VerLiquidacionForm? _formPadreLiquidacion;
        private List<CuentaContableResponse> _cuentas = new();

        private string? _liquidacionId;

        public CargarPagosForm(LiquidacionController liquidacionController)
        {
            InitializeComponent();
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

        private void CargarPagosForm_Load(object sender, EventArgs e)
        {
            var cuentaSantander = new CuentaContableResponse("1003", "Santander", "");
            var cuentaEfectivo = new CuentaContableResponse("1002", "Efectivo", "");
            var otrasCuentas = new CuentaContableResponse("3049", "Otras cuentas digitales / billeteras", "");

            _cuentas = new List<CuentaContableResponse>
                        {
                            cuentaEfectivo,
                            cuentaSantander,
                            otrasCuentas
                          };

            comboBoxCuentasContables.DataSource = _cuentas.ToList();

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
            if (_formPadreLiquidacion is null)
            {
                return;
            }

            var liq = await _liquidacionController.GetById(liquidacionId);

            _formPadreLiquidacion.SetLiquidacion(liq ?? throw new Exception("liq.null"));

            this.Close();
        }

        private void RadioButtonTransferencia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTransferencia.Checked)
            {
                // Todas menos 1002
                comboBoxCuentasContables.DataSource = _cuentas
                    .Where(c => c.Id != "1002")
                    .ToList();
            }
            else
            {
                // Solo cuenta 1002
                comboBoxCuentasContables.DataSource = _cuentas
                    .Where(c => c.Id == "1002")
                    .ToList();
            }
        }
    }
}
