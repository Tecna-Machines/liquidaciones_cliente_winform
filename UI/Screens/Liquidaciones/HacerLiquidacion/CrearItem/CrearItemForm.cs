using BLL.Controllers;
using DAL.Service.ApiLiquidacion.Features.Liquidacion.AgregarItem;
using UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion;
using UI.Utils;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearItemForm : Form
    {
        private readonly LiquidacionController _controller;
        private string _codigoLiquidacion;
        public CrearItemForm(LiquidacionController controller)
        {
            InitializeComponent();

            _controller = controller;
            _codigoLiquidacion = "-99999";
        }

        //TODO: toda esta funcionalidad esta sucia y rebuscada , debe de refactorizarse (algun dia)
        private async void BtnAgregar_Click(object sender, EventArgs e)
        {
            string concepto = textBoxConcepto.Text;
            string montoStr = textBoxMonto.Text;
            decimal monto;
            bool esDecimal = decimal.TryParse(montoStr, out monto);


            var itemData = new CrearItemRequest(concepto,
                                                monto,
                                                VerSiEsEnBlanco(),
                                                RecuperarTipo());

            await _controller.AgregarItem(_codigoLiquidacion, itemData);

            Dialog.Success("se agrego el item!");
        }

        private int RecuperarTipo()
        {
            int indexBoxSeleccionado = comboBoxTipo.SelectedIndex;

            if (indexBoxSeleccionado == 0)
            {
                return (int)TipoItemLiquidacion.Remunerativo;
            }

            if (indexBoxSeleccionado == 1)
            {
                return (int)TipoItemLiquidacion.Remunerativo;
            }

            if (indexBoxSeleccionado == 2)
            {
                return (int)TipoItemLiquidacion.NoRemunerativo;
            }

            if (indexBoxSeleccionado == 3)
            {
                return (int)TipoItemLiquidacion.Descuento;
            }

            throw new InvalidCastException();
        }

        private bool VerSiEsEnBlanco()
        {
            int tipo = RecuperarTipo();

            if (tipo == 0) return true;
            if (tipo == 1) return false;
            if (tipo == 2) return true;
            if (tipo == 3) return false;

            throw new InvalidCastException();
        }

        public void SetLiquidacion(string codigo) => _codigoLiquidacion = codigo;

    }
}
