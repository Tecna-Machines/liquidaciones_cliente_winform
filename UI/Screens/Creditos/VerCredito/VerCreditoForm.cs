using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;
using System.Threading.Tasks;
using UI.Screens.Creditos.CrearPlanPago;
using UI.Screens.VerLiquidacion;
using UI.Utils;

namespace UI.Screens.Creditos.VerCredito
{
    public partial class VerCreditoForm : Form
    {
        private readonly CreditoController _controllerCredito;
        private readonly LiquidacionController _controllerLiquidacion;
        private CrearPlanDePagoForm _formPlanPago;

        private VerLiquidacionForm _formVerLiquidacion;
        public VerCreditoForm(CreditoController controller,
                             CrearPlanDePagoForm formPlanPago,
                             VerLiquidacionForm formVerLiquidacion,
                             LiquidacionController controllerLiquidacion)
        {
            InitializeComponent();
            _controllerCredito = controller;
            _formPlanPago = formPlanPago;
            _formVerLiquidacion = formVerLiquidacion;
            _controllerLiquidacion = controllerLiquidacion;
        }

        public void SetCredito(GetCreditoResponse credito)
        {
            LimpiarFormulario();

            textCodigo.Text = credito.Codigo;
            textDni.Text = credito.DniEmpleado;
            textNombreCompleto.Text = credito.NombreApellido;

            TextDescripcion.Text = credito.Descripcion;
            textMontoPrestado.Text = credito.Prestado.ToString("C");
            textMontoDevoler.Text = credito.Devolver.ToString("C");
            textModoPago.Text = credito.ModoPago;

            CargarTablaCuotas(credito.Cuotas);

            _formPlanPago.SetCredito(credito);

        }

        private void CargarTablaCuotas(IEnumerable<CuotaResponse> cuotas)
        {
            foreach (var cuota in cuotas)
            {
                var item = CrearItem(cuota);

                tablaCuotas.Items.Add(item);
            }
        }

        private ListViewItem CrearItem(CuotaResponse c)
        {
            var item = new ListViewItem(c.Nro);
            item.Tag = c;
            item.SubItems.Add(c.Descripcion);
            item.SubItems.Add(c.Monto.ToString("C"));
            item.SubItems.Add(GenerarStringQuincena(c.Quincena));

            if (string.IsNullOrEmpty(c.Pago!.CodigoLiquidacion))
            {
                item.SubItems.Add("SIN PAGAR");
            }
            else
            {
                item.SubItems.Add("PAGADA");
            }


            return item;
        }

        private string GenerarStringQuincena(QuincenaCuota q)
        {
            string sufijo = "ra";

            if (q.Quincena == 2)
                sufijo = "da";

            return $"{q.Quincena}{sufijo} de {q.Mes} de {q.Anio}";
        }

        private void LimpiarFormulario()
        {
            textCodigo.Text = "";
            textDni.Text = "";
            textNombreCompleto.Text = "";
            TextDescripcion.Text = "";
            textMontoPrestado.Text = "";
            textMontoDevoler.Text = "";
            textModoPago.Text = "";

            tablaCuotas.Items.Clear();
        }

        private void TablaCuotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tablaCuotas.SelectedItems.Count == 1)
            {
                int indx = tablaCuotas.SelectedItems[0].Index;
                var itemSeleccionado = tablaCuotas.Items[indx].Tag as CuotaResponse;

                SetearDatosCuota(itemSeleccionado);
            }
        }

        private void BtnPosponerCuota_Click(object sender, EventArgs e)
        {
            PosponerCuota();
        }

        private async void PosponerCuota()
        {

            progressBar.Visible = true;
            BtnPosponerCuota.Enabled = false;
            this.Enabled = false;

            string codigoCredito = textCodigo.Text;
            int nroCuota = int.Parse(textCuotaNro.Text);

            try
            {
                await _controllerCredito.PosponerCuotas(codigoCredito, nroCuota);
                Dialog.Success("cuotas actualizadas");
                this.Close();
            }
            catch (Exception e)
            {
                Dialog.Error("ocurrio un problema: " + e.Message);
            }
            finally
            {
                progressBar.Visible = false;
                BtnPosponerCuota.Enabled = true;
                this.Enabled = true;
            }


        }

        private void SetearDatosCuota(CuotaResponse? cuota)
        {
            if (cuota is null)
                return;

            textCuotaNro.Text = cuota.Nro;
            textCuotaDescripcion.Text = cuota.Descripcion;
            textCuotaMonto.Text = cuota.Monto.ToString("C");
            textCuotaDescripcion.Text = cuota.Descripcion;
            textCuotaQuincena.Text = GenerarStringQuincena(cuota.Quincena);
            VerificarSiEstaPaga(cuota);

            textBoxCodigoLiquidacion.Text = cuota.Pago.CodigoLiquidacion;
        }

        public void VerificarSiEstaPaga(CuotaResponse c)
        {
            if (string.IsNullOrEmpty(c.Pago.CodigoLiquidacion))
            {
                textCuotaPagada.Text = "SIN PAGAR";
                textCuotaPagada.ForeColor = Color.Red;
                BtnVerLiquidacion.Enabled = false;
                BtnPosponerCuota.Enabled = true;

                return;
            }

            textCuotaPagada.Text = "PAGADA";
            textCuotaPagada.ForeColor = Color.DarkOliveGreen;
            BtnPosponerCuota.Enabled = false;
            BtnVerLiquidacion.Enabled = true;

        }

        private void BtnPlanDePago_Click(object sender, EventArgs e)
        {

            _formPlanPago.ShowDialog();
        }

        private async void BtnVerLiquidacion_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Deshabilitar el botón para evitar múltiples clics mientras carga
                BtnVerLiquidacion.Enabled = false;

                // 2. Ejecutar la tarea asíncrona
                await RecuperarLiquidacion(textBoxCodigoLiquidacion.Text);

                // 3. Mostrar el formulario
                _formVerLiquidacion.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al recuperar la liquidación: {ex.Message}");
            }
            finally
            {
                // 4. Re-habilitar el botón
                BtnVerLiquidacion.Enabled = true;
            }
        }

        private async Task RecuperarLiquidacion(string codigoLiquidacion)
        {
            var liq = await _controllerLiquidacion.GetById(codigoLiquidacion);
            _formVerLiquidacion.SetLiquidacion(liq!);
        }
    }
}
