using BLL.Controllers;
using BLL.Models;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion.ItemForm
{
    public partial class AgregarRemuneracionForm : Form
    {
        private Form _formAnterior;
        private bool _esRemuneracionBlanca;
        private readonly AgregarItemController _itemController;
        public AgregarRemuneracionForm(Form formAnterior,AgregarItemController itemController)
        {

            InitializeComponent();

            this._itemController = itemController;
            this._formAnterior = formAnterior;
            this.Configurar();
        }

        private void Configurar()
        {
            _formAnterior.Close();

            this.btnRespuesta_si.BackColor = Color.LightGreen;
            this._esRemuneracionBlanca = true;
        }

        private void btnRespuesta_si_Click(object sender, EventArgs e)
        {
            this._esRemuneracionBlanca = true;
            this.btnRespuesta_si.BackColor = Color.LightGreen;
            this.btnRespuesta_no.BackColor = SystemColors.Window;
        }

        private void btnRespuesta_no_Click(object sender, EventArgs e)
        {
            this._esRemuneracionBlanca = false;
            this.btnRespuesta_si.BackColor = SystemColors.Window;
            this.btnRespuesta_no.BackColor = Color.LightGreen;
        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageUtils.PopUpDeConfirmacion("estas seguro de agregar este item?",
                                                                    "confirma remuneracion");

            if (!result.HasFlag(DialogResult.Yes))
            {
                return;
            }

            var context = LiquidacionContext.GetInstance();
            string numeroCuenta = context.ObtenerDatosEmpleado().NumeroCuenta;

            string montoStr = this.textBoxMonto.Text;


            string descripcion = this.textBoxDescripcion.Text;

            try
            {
                var remu = await _itemController.CrearUnaRemuneracion(descripcion: descripcion,
                                                                    numeroCuenta: numeroCuenta,
                                                                    monto: montoStr,
                                                                    esBlanco: this._esRemuneracionBlanca);
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un problema");
                return;
            }

            MessageBox.Show("se creo la remuneracion exitosamente");


        }
    }
}
