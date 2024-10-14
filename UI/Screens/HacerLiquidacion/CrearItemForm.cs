using BLL.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Screens.HacerLiquidacion.ItemForm;

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
            var form = new AgregarRemuneracionForm(this, this._controller);
            form.Show();
        }

        private void btnDesc_Click(object sender, EventArgs e)
        {
            var form = new AgregarDescuentoForm(this, this._controller);
            form.Show();
        }

        private void btnRetencion_Click(object sender, EventArgs e)
        {
            var form = new AgregarRetencionForm(this, this._controller);
            form.Show();
        }
    }
}
