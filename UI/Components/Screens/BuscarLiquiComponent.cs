using BLL.Controllers;
using BLL.Models;
using LAUCHA.application.DTOs.LiquidacionDTOs;
using LAUCHA.application.DTOs.PaginaDTOs;
using UI.Screens.VerLiquidacion;

namespace UI.Components.Screens
{
    public partial class BuscarLiquiComponent : UserControl
    {
        private ConsultarLiquidacionController _ControllerLiquidacion;
        public BuscarLiquiComponent()
        {
            InitializeComponent();

            _ControllerLiquidacion = new();
            this.listaLiquidaciones.ItemSelectionChanged += SelectItemListaLiquidacion;
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

        private async void SelectItemListaLiquidacion(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Verificar si un elemento está seleccionado
            try
            {
                if (e.IsSelected)
                {
                    // Recuperar el valor de la primera columna (index 0)
                    string codigoLiquidacion = e.Item.SubItems[0].Text.Trim();

                    var liquidacion = await _ControllerLiquidacion.ConsultarLiquidacionById(codigoLiquidacion);

                    var contexto = LiquidacionContext.GetInstance();

                    contexto.SetLiquidacion(liquidacion);

                    var formlIquidacion = new VerLiquidacionForm();
                    formlIquidacion.Show();
                }
            }catch(Exception)
            {
                MessageBox.Show("ocurrio una catastrofe");
            }
        }

    }
}
