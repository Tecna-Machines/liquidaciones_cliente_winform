using DAL.Service.Liquidacion.UseCase.Contrato.Crear;

namespace UI.Screens.CrearContrato
{
    public partial class CrearAdicionalForm : Form
    {
        private CrearAcuerdoForm _acuerdoForm;
        public CrearAdicionalForm(CrearAcuerdoForm contratoForm)
        {
            _acuerdoForm = contratoForm;
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            var adicional = CrearAdicional();
            _acuerdoForm.AgregarAdicional(adicional);

            this.Close();
        }

        private AdicionalesRequest CrearAdicional()
        {
            string concepto = textBoxDescripcion.Text;
            bool esEnBlanco = checkBoxEsEnBlanco.Checked;
            bool esPorcentual = checkBoxEsPorcentual.Checked;

            decimal monto;
            decimal.TryParse(textBoxMonto.Text, out monto);

            return new AdicionalesRequest(concepto, esEnBlanco, esPorcentual, monto);
        }
    }
}
