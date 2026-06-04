using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using UI.Screens.CrearContrato;
using UI.Screens.CrearEmpleado;
using UI.Screens.Creditos.BuscarCredito;
using UI.Screens.Feriados.CrearFeriado;
using UI.Screens.Liquidaciones.HistorialLiquidaciones;
using UI.Screens.VerContratos;
using UI.Screens.VerCreditos;

namespace UI
{
    public partial class Home : Form
    {

        public Home()
        {
            InitializeComponent();

            string apiBaseUrl = ConfigurationManager.AppSettings["server"] ?? "error";
            string clientVersion = ConfigurationManager.AppSettings["client_version"] ?? "error";

            toolStripStatusLabelServidor.Text = "Servidor: "+apiBaseUrl;
            toolStripStatusVersion.Text = "Version del cliente: "+clientVersion;

        }

        private void ShowPanelContexto(Control content)
        {
            panelPrincipal.Controls.Clear();
            content.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(content);
        }

        private void ClickBtnInicio(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            panelPrincipal.Controls.Add(this.pictureBoxLogo);
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

        private void CrearCreditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCrearCredito = Program.ServiceProvider.GetRequiredService<CrearCreditosForm>();
            formCrearCredito.ShowDialog();
        }

        private void ConsultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formBuscarCreditos = Program.ServiceProvider.GetRequiredService<BuscarCreditosForm>();
            formBuscarCreditos.Show();
        }


        private void CrearFeriadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFeriado = Program.ServiceProvider.GetRequiredService<CrearFeriadoForm>();
            formFeriado.ShowDialog();
        }
    }
}
