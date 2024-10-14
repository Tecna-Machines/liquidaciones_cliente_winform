namespace UI.Components.Utils
{
    partial class ListaEmpComponent
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            barraBusqueda = new TextBox();
            listEmp = new ListView();
            columnNombre = new ColumnHeader();
            columApellido = new ColumnHeader();
            labelNombre = new Label();
            SuspendLayout();
            // 
            // barraBusqueda
            // 
            barraBusqueda.Location = new Point(15, 29);
            barraBusqueda.Name = "barraBusqueda";
            barraBusqueda.Size = new Size(270, 23);
            barraBusqueda.TabIndex = 0;
            barraBusqueda.TextChanged += BuscarEmpUsandoNombre;
            // 
            // listEmp
            // 
            listEmp.Columns.AddRange(new ColumnHeader[] { columnNombre, columApellido });
            listEmp.FullRowSelect = true;
            listEmp.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listEmp.Location = new Point(15, 58);
            listEmp.Name = "listEmp";
            listEmp.Size = new Size(270, 615);
            listEmp.TabIndex = 1;
            listEmp.UseCompatibleStateImageBehavior = false;
            listEmp.View = View.Details;
            listEmp.SelectedIndexChanged += ClickEnEmpleado;
            // 
            // columnNombre
            // 
            columnNombre.Text = "Nombre";
            columnNombre.Width = 135;
            // 
            // columApellido
            // 
            columApellido.Text = "Apellido";
            columApellido.Width = 135;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(15, 11);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(124, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Buscar (por nombre):";
            // 
            // ListaEmpComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelNombre);
            Controls.Add(listEmp);
            Controls.Add(barraBusqueda);
            Name = "ListaEmpComponent";
            Size = new Size(304, 690);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox barraBusqueda;
        private ListView listEmp;
        private ColumnHeader columnNombre;
        public ColumnHeader columApellido;
        private Label labelNombre;
    }
}
