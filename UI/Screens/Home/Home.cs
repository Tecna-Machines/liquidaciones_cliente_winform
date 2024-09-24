using BLL.Controllers;
using UI.Components.Screens;

namespace UI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void ShowPanelContexto(Control content)
        {
            panelPrincipal.Controls.Clear();
            content.Dock = DockStyle.Fill;
            this.panelPrincipal.Controls.Add(content);
        }

    }
}
