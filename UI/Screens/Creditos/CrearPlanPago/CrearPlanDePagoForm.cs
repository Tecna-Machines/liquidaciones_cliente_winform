using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Creditos.CrearPlanPago;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using UI.Utils;

namespace UI.Screens.Creditos.CrearPlanPago
{
    public partial class CrearPlanDePagoForm : Form
    {
        private readonly CreditoController _controllerCredito;
        private GetCreditoResponse? _credito;
        public CrearPlanDePagoForm(CreditoController controllerCredito)
        {
            InitializeComponent();
            _controllerCredito = controllerCredito;
        }

        public void SetCredito(GetCreditoResponse credito)
        {
            _credito = credito;

            textBoxDebe.Text = CalcularMotoFaltante().ToString("C");
        }

        private decimal CalcularMotoFaltante()
        {
            if (_credito is null)
            {
                MessageBox.Show("credito.null");
                return -1;
            }

            decimal montoDevuelto = 0;

            foreach (var cuota in _credito.Cuotas)
            {
                if (cuota.Pago is not null)
                {
                    montoDevuelto += cuota.Monto;
                }
            }
            return _credito.Devolver - montoDevuelto;
        }

        private void ComboBoxCantCuotas_SelectedValueChanged(object sender, EventArgs e)
        {
            ActualizarMontoNuevaCuota();
        }

        private void ActualizarMontoNuevaCuota()
        {
            decimal montoDevolver = CalcularMotoFaltante();

            var itemSeleccionado = comboBoxCantCuotas.SelectedItem;

            int cantCuotas = 1;

            if (itemSeleccionado is not null)
                cantCuotas = int.Parse(comboBoxCantCuotas.SelectedItem.ToString() ?? "1");


            string valorCuota = (montoDevolver / cantCuotas).ToString("F2");

            textBoxMontoCuota.Text = valorCuota;
        }

        private void BtnCrearPlan_Click(object sender, EventArgs e)
        {
            CrearPlanDePago();
        }

        private async void CrearPlanDePago()
        {
            if (_credito is null)
            {
                Dialog.Error("credito es nulo");
                return;
            }

            var informacionPlan = CrearSolicitudPlan();
            string codigoCredito = _credito.Codigo;

            try
            {
                var credito = await _controllerCredito.CrearPlanDePago(codigoCredito, informacionPlan);
                Dialog.Success($"se creo un plan de pago para el credito: {credito.CodigoCredito}");

                this.Close();

            }
            catch (Exception e)
            {
                Dialog.Error($"ocurrio un problema: {e.Message}");
            }
        }

        private CrearPlanDePagoRequest CrearSolicitudPlan()
        {
            var quincena = int.Parse(comboBoxQuincena.Text);
            var mes = int.Parse(comboBoxMes.Text);
            var anio = int.Parse(comboBoxAnio.Text);
            var cantCuotas = int.Parse(comboBoxCantCuotas.Text);

            return new CrearPlanDePagoRequest(quincena, mes, anio, cantCuotas);
        }
    }

}
