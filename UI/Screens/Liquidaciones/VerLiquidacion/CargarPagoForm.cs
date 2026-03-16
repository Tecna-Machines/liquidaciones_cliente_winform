namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    public partial class pagos : Form
    {
        public pagos()
        {
            InitializeComponent();
        }

        private void TextBoxMonto_TextChanged(object sender, EventArgs e)
        {
            string montoStr = textBoxMonto.Text;
            decimal monto;

            decimal.TryParse(montoStr, out monto);

            textBoxMontoContab.Text = monto.ToString("C");
        }
    }
}
