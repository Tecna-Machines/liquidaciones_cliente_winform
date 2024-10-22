using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Utils;

namespace UI.Screens.VerCreditos
{
    public partial class VerCreditosForm : Form
    {
        public VerCreditosForm()
        {
            InitializeComponent();

            this.listaEmpComponent1.ForzarCargarLista();
        }

        private void btnCrearCredito_Click(object sender, EventArgs e)
        {
            MessageUtils.ErrorMessage("esta funcionalidad aun no esta disponible");
        }
    }
}
