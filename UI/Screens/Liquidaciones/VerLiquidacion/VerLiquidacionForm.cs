using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.GetById;
using DAL.Service.Liquidacion.Features.Liquidacion.GetById;
using System.Diagnostics;
using UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion;
using UI.Screens.Liquidaciones.VerLiquidacion;

namespace UI.Screens.VerLiquidacion
{
    public partial class VerLiquidacionForm : Form
    {
        private readonly LiquidacionController _liquidacion;
        private readonly CargarPagosForm _formPagos;
        public VerLiquidacionForm(LiquidacionController liquidacion,
                                  CargarPagosForm formPagos)
        {
            InitializeComponent();

            _liquidacion = liquidacion;
            _formPagos = formPagos;
        }

        public void SetLiquidacion(GetLiquidacionByIdResponse liq)
        {
            tablaPagos.Items.Clear();
            tablaAcuerdo.Items.Clear();
            tablaDetalleBlanco.Items.Clear();
            tablaDetalleNegro.Items.Clear();

            TablaDetalleLiquidacionForm.SetTablaDetalleEnBlanco(liq, tablaDetalleBlanco);
            TablaDetalleLiquidacionForm.SetTablaDetalleEnNegro(liq, tablaDetalleNegro);
            TablaAcuerdoLiquidacionForm.SetTablaAcuerdo(liq, tablaAcuerdo);
            TablaPagosLiquidacionForm.SetTablaPagos(liq, tablaPagos);

            SetDatosLiquidacion(liq);
            SetDetalleEmpleado(liq);

            labelNetoInterno.Text = liq.MontosPago.NetoInterno.ToString("C");
            labelNetoOficial.Text = liq.MontosPago.NetoOficial.ToString("C");


            SetTotalesOficial(liq);
            SetTotalesInternol(liq);
        }

        private void SetDatosLiquidacion(GetLiquidacionByIdResponse liq)
        {
            string quincena = "1ra";
            textBoxCodigoLiq.Text = liq.Codigo;

            if (liq.Quincena.Nro == 2)
                quincena = "2da";

            textBoxPeriodo.Text = $"{quincena} del {liq.Quincena.Mes} de{liq.Quincena.Anio}";

            if (!liq.SeSello)
            {
                textBoxEstado.Text = "PENDIENTE";
                textBoxEstado.ForeColor = Color.Red;
            }
            else
            {
                textBoxEstado.Text = "SELLADA";
                textBoxEstado.ForeColor = Color.DarkGreen;
            }

        }



        private void SetDetalleEmpleado(GetLiquidacionByIdResponse liq)
        {
            textBoxDni.Text = liq.Empleado.Dni;
            textBoxNombre.Text = $"{liq.Empleado.Nombre}";
            textBoxApellido.Text = $"{liq.Empleado.Apellido}";
            textBoxFechaIng.Text = liq.Empleado.FechaIngreso.ToString("dd/MM/yyyy");
            textBoxFechaAlta.Text = liq.Empleado.FechaAlta.ToString("dd/MM/yyyy");

        }

        private async void ClickBtnGenerarRecibo(object sender, EventArgs e)
        {
            try
            {
                // Mostrar barra de progreso al comenzar la operación
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee; // Indicador de progreso indefinido

                var pdfBytes = await _liquidacion.DescargarRecibo(textBoxCodigoLiq.Text);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Guardar Recibo";
                    saveFileDialog.FileName = $"recibo-{textBoxDni.Text}.pdf"; // Nombre por defecto

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show("PDF descargado y guardado correctamente.",
                                            "Éxito", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                        var psi = new ProcessStartInfo
                        {
                            FileName = saveFileDialog.FileName,
                            UseShellExecute = true
                        };

                        Process.Start(psi);
                    }
                }
            }
            catch (Exception ex)
            {
                // Mostrar mensaje de error si ocurre algún problema
                MessageBox.Show($"Error al descargar el recibo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                progressBar.Visible = false;
            }
        }

        private void BtnPagos_Click(object sender, EventArgs e)
        {
            _formPagos.SetIdLiquidacion(textBoxCodigoLiq.Text);
            _formPagos.SetFormPadre(this);
            _formPagos.ShowDialog();
        }

        private void SetTotalesOficial(GetLiquidacionByIdResponse liquidacion)
        {
            // Footer de totales oficial
            lvTotalesOficial.Items.Clear();


            var itOficial = new ListViewItem("Totales:");

            itOficial.SubItems.Add(liquidacion.ObtenerBrutoOficial().ToString("C"));          // $ remun
            itOficial.SubItems.Add(liquidacion.ObtenerRetencionesOficiales().ToString("C")); // $ descuentos
            itOficial.SubItems.Add(liquidacion.ObtenerNoRemunerativo().ToString("C"));        // $ no remu
            itOficial.SubItems.Add(string.Empty);                                             // vacío

            lvTotalesOficial.Items.Add(itOficial);
        }

        private void SetTotalesInternol(GetLiquidacionByIdResponse liquidacion)
        {
            // Footer de totales oficial
            lvTotalesInterno.Items.Clear();


            var itOficial = new ListViewItem("Totales:");

            itOficial.SubItems.Add(liquidacion.ObtenerBrutoInterno().ToString("C"));          // $ remun
            itOficial.SubItems.Add(liquidacion.ObtenerDescuentosInterno().ToString("C")); // $ descuentos
            itOficial.SubItems.Add(string.Empty);                                             // vacío

            lvTotalesInterno.Items.Add(itOficial);
        }
    }

}

