using BLL.Controllers;
using System.Configuration;
using UI.Components.Screens;
using UI.Screens.CrearContrato;
using UI.Screens.VerContratos;

namespace UI
{
    public partial class Home : Form
    {
        private readonly VerAcuerdoForm _verAcuerdo;
        private readonly CrearAcuerdoForm _crearAcuerdo;

        public Home(VerAcuerdoForm verAcuerdo, CrearAcuerdoForm crearAcuerdo)
        {
            InitializeComponent();

            string apiBaseUrl = ConfigurationManager.AppSettings["server"]!;
            labelServerInfo.Text = $"SERVER: {apiBaseUrl}";

            _verAcuerdo = verAcuerdo;
            _crearAcuerdo = crearAcuerdo;
            //_verCreditoForm = verCreditoForm;
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
            _crearAcuerdo.Show();
        }

        private void btnHistorialTrabajo_Click(object sender, EventArgs e)
        {
            _verAcuerdo.ShowDialog();
        }

        private void btnCreditos_Click(object sender, EventArgs e)
        {
            //var formCreditos = new VerCreditosForm();
            //formCreditos.ShowDialog();
        }
    }
}
