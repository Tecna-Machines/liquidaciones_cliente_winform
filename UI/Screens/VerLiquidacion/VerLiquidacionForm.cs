using BLL.Controllers;
using BLL.Models;
using LAUCHA.application.DTOs.EmpleadoDTO;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using UI.Utils;

namespace UI.Screens.VerLiquidacion
{
    public partial class VerLiquidacionForm : Form
    {
        private readonly EmpleadoController empleadoController;
        public VerLiquidacionForm()
        {
            empleadoController = new();
            InitializeComponent();

            var contexto = LiquidacionContext.GetInstance();

            this.CargarTablaDetalleLiquidacion(contexto.ObtenerLiquidacion()!);
            this.CargarTablaAcuerdo(contexto.ObtenerLiquidacion()!);
            this.CargarTablaSueldoBlanco(contexto.ObtenerLiquidacion()!);
            this.CargarTablaSueldoBillete(contexto.ObtenerLiquidacion()!);
            this.CargarTablaEmpleado(contexto.ObtenerLiquidacion()!);
            this.AjustarTablas();
        }

        private void CargarTablaDetalleLiquidacion(LiquidacionDTO liquidacion)
        {
            this.textBoxCodigoLiq.Text = liquidacion.Codigo;
            this.textBoxFechaInicio.Text = liquidacion.Periodo.Inicio.ToString("dd/MM/yyyy");
            this.textBoxFechaFin.Text = liquidacion.Periodo.Fin.ToString("dd/MM/yyyy");

            if (liquidacion.Periodo.Inicio.Day < 15)
            {
                this.textBoxPeriodo.Text = $"2da Quicena de {liquidacion.Periodo.Inicio.ToString("MMMM")}";
            }
            else
            {
                this.textBoxPeriodo.Text = $"1ra Quicena de {liquidacion.Periodo.Inicio.ToString("MMMM")}";

            }
        }

        private void CargarTablaAcuerdo(LiquidacionDTO liquidacion)
        {
            var acuerdo = liquidacion.Contrato;

            this.textBoxCodigoContrato.Text = acuerdo.Codigo;
            this.textBoxModalidad.Text = acuerdo.Modalidad.Descripcion;
            this.textBoxFechaContrato.Text = acuerdo.Fecha;
            this.textBoxMontoFijoContrato.Text = acuerdo.MontoFijo.ToString("c");
            this.textBoxMontoHoraContrato.Text = acuerdo.MontoHora.ToString("c");

            if (acuerdo.AcuerdoBlanco.EsPorcentual)
            {
                this.textBoxParteBlancaContrato.Text = $"{acuerdo.AcuerdoBlanco.Cantidad} %";
            }
            else
            {
                this.textBoxParteBlancaContrato.Text = acuerdo.AcuerdoBlanco.Cantidad.ToString("c");
            }
        }

        private void CargarTablaSueldoBlanco(LiquidacionDTO liquidacion)
        {

            liquidacion.Items.Remuneraciones.Where(r => r.EsBlanco == true).ToList().ForEach(r =>
            {
                DateTime result;
                DateTime.TryParse(r.Fecha, out result);

                var item = new ListViewItem(r.Descripcion);
                item.SubItems.Add(result.ToString("dd/MM/yyyyy"));
                item.SubItems.Add(r.Monto.ToString("c"));
                item.SubItems.Add("");
                item.SubItems.Add("");

                this.listaSueldoBlanco.Items.Add(item);
            });

            liquidacion.Items.Retenciones.ForEach(rt =>
            {
                var item = new ListViewItem(rt.Descripcion);
                item.SubItems.Add(rt.Fecha.ToString("dd/MM/yyyyy"));
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add(rt.Monto.ToString("c"));

                this.listaSueldoBlanco.Items.Add(item);
            });
        }

        private void CargarTablaSueldoBillete(LiquidacionDTO liquidacion)
        {
            liquidacion.Items.Remuneraciones.Where(r => r.EsBlanco == false).ToList().ForEach(rn =>
            {
                DateTime result;
                DateTime.TryParse(rn.Fecha, out result);

                var item = new ListViewItem(rn.Descripcion);
                item.SubItems.Add(result.ToString("dd/MM/yyyy"));
                item.SubItems.Add(rn.Monto.ToString("c"));

                listaSueldoBillete.Items.Add(item);

            });

            liquidacion.Items.Descuentos.ForEach(d =>
            {
                var item = new ListViewItem(d.Descripcion);
                item.SubItems.Add(d.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(d.Monto.ToString("c"));

                listaSueldoBillete.Items.Add(item);
            });
        }

        private async void CargarTablaEmpleado(LiquidacionDTO liquidacion)
        {
            string dniEmp = liquidacion.Dni;

            EmpleadoDTO emp = await this.empleadoController.ObtenerDataEmpleado(dniEmp);

            this.textBoxDni.Text = emp.Dni;
            this.textBoxNombre.Text = emp.Nombre;
            this.textBoxApellido.Text = emp.Apellido;
            this.textBoxFechaIng.Text = emp.FechaIngreso.ToString("dd/MM/yyyy");
            this.textBoxFechaCreacion.Text = emp.FechaCreacion.ToString("dd/MM/yyyy");
        }

        private void AjustarTablas()
        {
            ListUtils.AjustarColumnas(this.listaSueldoBillete);
            ListUtils.AjustarColumnas(this.listaSueldoBlanco);
            ListUtils.AjustarColumnas(this.listaPagos);
        }

        private async void ClickBtnGenerarRecibo(object sender, EventArgs e)
        {
            try
            {
                // Mostrar barra de progreso al comenzar la operación
                progressBar.Visible = true;
                progressBar.Style = ProgressBarStyle.Marquee; // Indicador de progreso indefinido

                var liquidacion = LiquidacionContext.GetInstance().ObtenerLiquidacion();
                string codigoLiq = liquidacion.Codigo;
                string nombreCompletao = liquidacion.Empleado;

                // Descargar el recibo en formato PDF desde la API
                var pdfBytes = await empleadoController.DescargarReciboLiquidacionEmp(codigoLiq);

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "PDF Files|*.pdf";
                    saveFileDialog.Title = "Guardar Recibo";
                    saveFileDialog.FileName = $"{nombreCompletao}_{codigoLiq}.pdf"; // Nombre por defecto

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        // Guardar el archivo PDF
                        File.WriteAllBytes(saveFileDialog.FileName, pdfBytes);
                        MessageBox.Show("PDF descargado y guardado correctamente.",
                                            "Éxito", MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
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
                // Ocultar la barra de progreso una vez que termine la operación
                progressBar.Visible = false;
            }
        }

    }

}

