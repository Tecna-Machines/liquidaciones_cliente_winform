using BLL.Controllers;
using BLL.Models;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion.ItemForm
{
    public partial class AgregarDescuentoForm : Form
    {
        private readonly AgregarItemController _itemController;
        public AgregarDescuentoForm(Form formAnterior, AgregarItemController itemController)
        {
            InitializeComponent();
            _itemController = itemController;

            formAnterior.Close();
        }

        private async void btnConfirmar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageUtils.PopUpDeConfirmacion("estas seguro de agregar este item?",
                                                                   "confirma descuento");

            if (!result.HasFlag(DialogResult.Yes))
            {
                return;
            }


            var context = LiquidacionContext.GetInstance();

            string descripcion = this.textBoxDescripcion.Text;
            string numeroCuenta = context.ObtenerDatosEmpleado().NumeroCuenta;
            string montoStr = this.textBoxMonto.Text;


            try
            {
                var descuento = await _itemController.CrearUnDescuento(description: descripcion,
                                                            numeroCuenta: numeroCuenta,
                                                            monto: montoStr,
                                                            numeroConcepto: null
                                                            );
            }
            catch(Exception)
            {
                MessageBox.Show("ocurrio un problema","error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            MessageBox.Show("se creo el descuento exitosamente");
        }
    }
}
