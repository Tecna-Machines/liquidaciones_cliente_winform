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
            Dialog.Error("esta funcionalidad aun no esta disponible");
        }
    }
}
