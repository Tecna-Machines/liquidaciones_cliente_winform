using BLL.Controllers;
using System.Configuration;
using UI.Components.Screens;
using UI.Screens.CrearContrato;
using UI.Screens.VerContratos;

namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();

            string apiBaseUrl = ConfigurationManager.AppSettings["server"]!;
            labelServerInfo.Text = $"SERVER: {apiBaseUrl}";
        }

        private void ShowPanelContexto(Control content)
        {
            panelPrincipal.Controls.Clear();
            content.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(content);
        }

        private void ClickBtnHacerLiquidacion(object sender, EventArgs e)
        {
            this.ShowPanelContexto(new PeriodoLiquiComponent());
        }



        private async void ClickBtnHistorialLiquidacion(object sender, EventArgs e)
        {
            var controllre = new ConsultarLiquidacionController();
            var pag = await controllre.ConsultarLiquidaciones(new DAL.Service.Liquidacion.UseCase.Liquidacion.FiltroLiquidacion());

            var buscardor = new BuscarLiquiComponent();
            this.ShowPanelContexto(buscardor);

            buscardor.CargarLista(pag);
        }



        private void ClickBtnInicio(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(this.pictureBoxLogo);
            panelPrincipal.Controls.Add(this.dataVersion);
            panelPrincipal.Controls.Add(this.labelServerInfo);
        }

        private void btnCrearEmpleado_Click(object sender, EventArgs e)
        {
            this.ShowPanelContexto(new AgregarEmpController());
        }

        private void btnCrearContrato_Click(object sender, EventArgs e)
        {
            var formContrato = new CrearContratoForm();
            formContrato.ShowDialog();
        }

        private void btnHistorialTrabajo_Click(object sender, EventArgs e)
        {
            var formHistorialContratos = new VerContratosForm();
            formHistorialContratos.ShowDialog();
        }
    }
}
