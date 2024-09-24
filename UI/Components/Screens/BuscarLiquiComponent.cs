using LAUCHA.application.DTOs.LiquidacionDTOs;
using LAUCHA.application.DTOs.PaginaDTOs;

namespace UI.Components.Screens
{
    public partial class BuscarLiquiComponent : UserControl
    {
        public BuscarLiquiComponent()
        {
            InitializeComponent();
        }


        public void CargarLista(PaginaDTO<LiquidacionResumenDTO> pagina)
        {
            var liquidaciones = pagina.Resultados;

            var lista = this.listaLiquidaciones;

            lista.Items.Clear();

            liquidaciones.ForEach(l =>
            {
                string periodo = $"{l.Periodo.Inicio.ToString("dd/MM/yyyy")} al  {l.Periodo.Fin.Date.ToString("dd/MM/yyyy")}";

                var item = new ListViewItem(l.Codigo);
                item.SubItems.Add(l.Concepto);
                item.SubItems.Add(l.Fecha.ToString("dd/MM/yyyy"));
                item.SubItems.Add(periodo);
                item.SubItems.Add(l.TotalRemuneraciones.ToString("c"));
                lista.Items.Add(item);
            });

            this.SetearLabelPagina(pagina.TotalEncontrados,pagina.Paginas,pagina.Index);
        }

        private void SetearLabelPagina(int cantidadResultados,int cantPaginas,int pagActual)
        {
            this.labelTotalResult.Text = $"Cant. resultados: {cantidadResultados}";
            this.labelPagina.Text = $"{pagActual} de {cantPaginas} pagina/s";
        }
    }
}
