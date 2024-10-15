using BLL.Controllers;
using LAUCHA.application.DTOs.ContratoDTOs;
using LAUCHA.application.DTOs.EmpleadoDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Components.Utils;
using UI.Utils;

namespace UI.Screens.CrearContrato
{
    public partial class ConfirmarContratoForm : Form
    {
        private readonly ContratoController _contratoController;
        private CrearContratoDTO _contratoCrear;
        private EmpleadoDTO _empleado;
        private string _modalidadDescripcion;
        public ConfirmarContratoForm(CrearContratoDTO contratoCrear, EmpleadoDTO empleado, string modalidadDescripcion)
        {
            InitializeComponent();
            _contratoCrear = contratoCrear;
            _empleado = empleado;
            _modalidadDescripcion = modalidadDescripcion;
            _contratoController = new();

            this.CargarTextBox();
        }

        private void CargarTextBox()
        {
            decimal brutoEfectivo = _contratoCrear.MontoFijo - _contratoCrear.AcuerdoBlanco.Cantidad;
            decimal brutoBanco = _contratoCrear.AcuerdoBlanco.Cantidad;

            this.TextBoxmontoBrutoTotal.Text = _contratoCrear.MontoFijo.ToString("C");
            this.TextBoxMontoHora.Text = _contratoCrear.MontoHora.ToString("C");

            this.TextBoxBrutoEfectivo.Text = brutoEfectivo.ToString("C");
            this.TextBoxBrutoBanco.Text = brutoBanco.ToString("C");

            this.TextBoxNombres.Text = $"{_empleado.Nombre} {_empleado.Apellido}";
            this.TextBoxDni.Text = _empleado.Dni;

            this.TextBoxModalidad.Text = _modalidadDescripcion;
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            var result = MessageUtils.PopUpDeConfirmacion("estas seguro de crear este contrato?",
                                                        "confirmar contrato");

            if (!result.HasFlag(DialogResult.Yes))
            {
                return;
            }

            var loadingForm = new SpinnerForm();
            loadingForm.Show();

            try
            {
                await _contratoController.CargarContrato(this._contratoCrear);
                MessageUtils.SuccessMessage("Contrato creado exitosamente.");

                this.Close();
            }
            catch(Exception)
            {
                MessageUtils.ErrorMessage("no se pudo crear el contrato");
            }
            finally
            {
                loadingForm.Close();
            }
        }
    }
}
