using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using System.Data;

namespace UI.Screens.Creditos.CrearPlanPago
{
    public partial class CrearPlanDePagoForm : Form
    {
        public CrearPlanDePagoForm()
        {
            InitializeComponent();
        }

        public void SetCredito(GetCreditoResponse credito)
        {
            //TODO: refactorizar esta porqueria por favor
            decimal montoDebe = credito.Devolver - credito.Cuotas.Where(c => !string.IsNullOrEmpty(c.Pago.CodigoLiquidacion)).Sum(c => c.Monto);
            textBoxDebe.Text = montoDebe.ToString("C");

        }

        private void CheckBoxHabilitarPlan_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHabilitarPlan.Checked)
            {
                HabilitarPlan();
            }
            else
            {
                DeshabilitarPlan();
            }
        }

        public void HabilitarPlan()
        {
            decimal montoCuota = decimal.Parse(textBoxDebe.Text) / 3;

            textBoxMontoCuota.Text = montoCuota.ToString("C");
        }

        public void DeshabilitarPlan()
        {

        }
    }

}
