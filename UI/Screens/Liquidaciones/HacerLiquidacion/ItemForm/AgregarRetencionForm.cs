using BLL.Controllers;
using BLL.Models;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion.ItemForm
{
    public partial class AgregarRetencionForm : Form
    {
        private readonly AgregarItemController _itemController;
        public AgregarRetencionForm(Form formAnterior, AgregarItemController controller)
        {
            InitializeComponent();

            this._itemController = controller;
            formAnterior.Close();
        }

        private async void BtnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = Dialog.PopUpDeConfirmacion("estas seguro de agregar este item?",
                                                                    "confirma retencion");

            if (!result.HasFlag(DialogResult.Yes))
            {
                return;
            }

            var context = LiquidacionContext.GetInstance();
            string numeroCuenta = context.ObtenerDatosEmpleado().Cuenta;

            string montoStr = this.textBoxMonto.Text;


            string descripcion = this.textBoxDescripcion.Text;

            try
            {
                var reten = await _itemController.CrearUnaRetencion(descripcion: descripcion,
                                                                    numeroCuenta: numeroCuenta,
                                                                    monto: montoStr);
            }
            catch (Exception)
            {
                MessageBox.Show("ocurrio un problema", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("se creo la remuneracion exitosamente");
        }
    }
}
