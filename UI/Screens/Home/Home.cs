using BLL.Controllers;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using UI.Components.Screens;
using UI.Screens.CrearContrato;
using UI.Screens.CrearEmpleado;
using UI.Screens.Liquidaciones.HistorialLiquidaciones;
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


        private void CrearEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crearEmpleado = Program.ServiceProvider.GetRequiredService<CrearEmpleadoForm>();
            crearEmpleado.ShowDialog();
        }

        private void CrearAcuerdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crearAcuerdo = Program.ServiceProvider.GetRequiredService<CrearAcuerdoForm>();
            crearAcuerdo.Show();
        }

        private void VerAcuerdosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var crearAcuerdo = Program.ServiceProvider.GetRequiredService<VerAcuerdosForm>();
            crearAcuerdo.Show();
        }

        private void CrearLiquidacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowPanelContexto(new PeriodoLiquiComponent());
        }

        private void HistorialLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formHistorial = Program.ServiceProvider.GetRequiredService<HistorialLiquidacionesForm>();
            formHistorial.ShowDialog();
        }

    }
}
