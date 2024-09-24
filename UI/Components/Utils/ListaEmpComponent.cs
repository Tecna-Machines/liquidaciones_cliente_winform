using LAUCHA.application.DTOs.EmpleadoDTO;

namespace UI.Components.Utils
{
    public partial class ListaEmpComponent : UserControl
    {
        private string dniEmp;
        public event EventHandler<string>? EventDniSeleccionado;
        public ListaEmpComponent()
        {
            this.dniEmp = string.Empty;
            InitializeComponent();
        }

        public void CargarLista(List<EmpleadoDTO> lista)
        {
            listEmp.Items.Clear();

            lista.ForEach(emp =>
            {
                var item = new ListViewItem(emp.Nombre);
                item.SubItems.Add(emp.Apellido);
                item.SubItems.Add(emp.Dni);

                if(emp.ContratoResumen.CodigoContrato == null)
                {
                    item.BackColor = Color.Red;
                }

                listEmp.Items.Add(item);
            });

        }

        private void BuscarEmpUsandoNombre(object sender, EventArgs e)
        {
            string nomMatch = this.barraBusqueda.Text;

            foreach (ListViewItem item in listEmp.Items)
            {
                if (string.IsNullOrWhiteSpace(nomMatch))
                {
                    item.BackColor = Color.White;
                }
                else if (item.Text.ToLower().Contains(nomMatch))
                {
                    item.BackColor = Color.Yellow;
                }
                else
                {
                    item.BackColor = Color.White;
                }
            }
        }

        private void ClickEnEmpleado(object sender, EventArgs e)
        {
            if (listEmp.SelectedItems.Count > 0)
            {
                // Obtener el primer elemento seleccionado
                ListViewItem selectedItem = listEmp.SelectedItems[0];
                string nombre = selectedItem.SubItems[0].Text;
                string dniEmp = selectedItem.SubItems[2].Text;
                this.dniEmp = dniEmp;
                EventDniSeleccionado?.Invoke(this, dniEmp);

                this.dniEmp = dniEmp;
            }
        }

        public string GetDniEmpleado()
        {
            return this.dniEmp;
        }
    }
}
