using BLL.Controllers;

namespace UI.Screens.HacerLiquidacion
{
    public partial class CrearItemForm : Form
    {
        private readonly AgregarItemController _controller;
        public CrearItemForm()
        {
            InitializeComponent();

            this._controller = new AgregarItemController();
        }

        private void btnRemuneracion_Click(object sender, EventArgs e)
        {

        }

        private void btnDesc_Click(object sender, EventArgs e)
        {

        }

        private void btnRetencion_Click(object sender, EventArgs e)
        {

        }
    }
}
