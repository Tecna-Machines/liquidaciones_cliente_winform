using DAL.Service.ApiLiquidacion.Features.Creditos.GetById;

namespace UI.Screens.Creditos.VerCredito
{
    public partial class VerCreditoForm : Form
    {
        public VerCreditoForm()
        {
            InitializeComponent();
        }

        public void SetCredito(GetCreditoResponse credito)
        {
            TextDescripcion.Text = credito.Descripcion;
            textMontoPrestado.Text = credito.Prestado.ToString("C");
            textMontoDevoler.Text = credito.Devolver.ToString("C");
            textModoPago.Text = credito.ModoPago;

            CargarTablaCuotas(credito.Cuotas);

        }

        private void CargarTablaCuotas(IEnumerable<CuotaResponse> cuotas)
        {
            foreach (var cuota in cuotas)
            {
                var item = CrearItem(cuota);

                tablaCuotas.Items.Add(item);
            }
        }

        private ListViewItem CrearItem(CuotaResponse c)
        {
            var item = new ListViewItem(c.Nro);
            item.SubItems.Add(c.Descripcion);
            item.SubItems.Add(c.Monto.ToString("C"));
            item.SubItems.Add(GenerarStringQuincena(c.Quincena));
            item.SubItems.Add("gg");

            return item;
        }

        private string GenerarStringQuincena(QuincenaCuota q)
        {
            string sufijo = "ra";

            if (q.Quincena == 2)
                sufijo = "da";

            return $"{q.Quincena}{sufijo} de {q.Mes} de {q.Anio}"; 
        }

 
    }
}
