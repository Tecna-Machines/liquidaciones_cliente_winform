using LAUCHA.application.DTOs.EmpleadoDTO;

namespace UI.Components.Utils
{
    public partial class ListaEmpComponent : UserControl
    {
        private string dniEmp;
        public event EventHandler<string>? EventDniSeleccionado;

        private List<ListViewItem> listaOriginal = new List<ListViewItem>();
        public ListaEmpComponent()
        {
            this.dniEmp = string.Empty;
            InitializeComponent();
        }

        public void CargarLista(List<EmpleadoDTO> lista)
        {
            listEmp.Items.Clear();
            listaOriginal.Clear();


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
                listaOriginal.Add((ListViewItem)item.Clone());
            });

        }

        private void BuscarEmpUsandoNombre(object sender, EventArgs e)
        {
            string nomMatch = this.barraBusqueda.Text.ToLower();

            // Desactivar el redibujado para evitar parpadeos
            listEmp.BeginUpdate();
            listEmp.Items.Clear(); // Limpiar la lista actual

            // Si la búsqueda está vacía, restauramos todos los ítems originales
            if (string.IsNullOrWhiteSpace(nomMatch))
            {
                listEmp.Items.AddRange(listaOriginal.ToArray());
            }
            else
            {
                // Si hay texto en la búsqueda, filtramos los ítems coincidentes usando foreach
                foreach (var item in listaOriginal)
                {
                    if (item.Text.ToLower().Contains(nomMatch))
                    {
                        listEmp.Items.Add((ListViewItem)item.Clone());
                    }
                }
            }

            // Reactivar el redibujado
            listEmp.EndUpdate();
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
