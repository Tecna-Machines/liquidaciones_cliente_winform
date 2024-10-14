namespace UI.Components.Screens
{
    partial class AgregarEmpController
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
            textBoxDni = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            fechaIngreso = new DateTimePicker();
            fechaNacimiento = new DateTimePicker();
            labelDni = new Label();
            labelNom = new Label();
            labelApellidos = new Label();
            labelNaci = new Label();
            labelFechaIng = new Label();
            labelTitulo = new Label();
            btnCrearEmp = new Button();
            label1 = new Label();
            checkedListRetenciones = new CheckedListBox();
            btnConfigCuenta = new Button();
            labelCuenta = new Label();
            textBoxNumeroCuenta = new TextBox();
            SuspendLayout();
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(50, 72);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(224, 23);
            textBoxDni.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(90, 110);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(184, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(90, 149);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(184, 23);
            textBoxApellido.TabIndex = 2;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Location = new Point(114, 227);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(160, 23);
            fechaIngreso.TabIndex = 3;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Location = new Point(141, 185);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(133, 23);
            fechaNacimiento.TabIndex = 4;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(9, 73);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(35, 19);
            labelDni.TabIndex = 5;
            labelDni.Text = "Dni:";
            // 
            // labelNom
            // 
            labelNom.AutoSize = true;
            labelNom.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNom.Location = new Point(3, 110);
            labelNom.Name = "labelNom";
            labelNom.Size = new Size(81, 19);
            labelNom.TabIndex = 6;
            labelNom.Text = "Nombre/s:";
            // 
            // labelApellidos
            // 
            labelApellidos.AutoSize = true;
            labelApellidos.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellidos.Location = new Point(3, 150);
            labelApellidos.Name = "labelApellidos";
            labelApellidos.Size = new Size(78, 19);
            labelApellidos.TabIndex = 7;
            labelApellidos.Text = "Apellido/s";
            // 
            // labelNaci
            // 
            labelNaci.AutoSize = true;
            labelNaci.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelNaci.Location = new Point(3, 185);
            labelNaci.Name = "labelNaci";
            labelNaci.Size = new Size(132, 19);
            labelNaci.TabIndex = 8;
            labelNaci.Text = "Fecha Nacimiento:";
            // 
            // labelFechaIng
            // 
            labelFechaIng.AutoSize = true;
            labelFechaIng.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelFechaIng.Location = new Point(3, 227);
            labelFechaIng.Name = "labelFechaIng";
            labelFechaIng.Size = new Size(105, 19);
            labelFechaIng.TabIndex = 9;
            labelFechaIng.Text = "Fecha ingreso:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("SansSerif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.Location = new Point(50, 33);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(224, 17);
            labelTitulo.TabIndex = 10;
            labelTitulo.Text = "FORMULARIO DE EMPLEADO";
            // 
            // btnCrearEmp
            // 
            btnCrearEmp.BackColor = SystemColors.ActiveBorder;
            btnCrearEmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCrearEmp.Location = new Point(50, 272);
            btnCrearEmp.Name = "btnCrearEmp";
            btnCrearEmp.Size = new Size(203, 46);
            btnCrearEmp.TabIndex = 11;
            btnCrearEmp.Text = "CREAR EMPLEADO";
            btnCrearEmp.UseVisualStyleBackColor = false;
            btnCrearEmp.Click += btnCrearEmp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 33);
            label1.Name = "label1";
            label1.Size = new Size(254, 17);
            label1.TabIndex = 12;
            label1.Text = "CONFIGURACION DE LA CUENTA";
            // 
            // checkedListRetenciones
            // 
            checkedListRetenciones.FormattingEnabled = true;
            checkedListRetenciones.Location = new Point(298, 124);
            checkedListRetenciones.Name = "checkedListRetenciones";
            checkedListRetenciones.Size = new Size(262, 112);
            checkedListRetenciones.TabIndex = 13;
            // 
            // btnConfigCuenta
            // 
            btnConfigCuenta.BackColor = SystemColors.ActiveBorder;
            btnConfigCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfigCuenta.Location = new Point(298, 272);
            btnConfigCuenta.Name = "btnConfigCuenta";
            btnConfigCuenta.Size = new Size(203, 46);
            btnConfigCuenta.TabIndex = 14;
            btnConfigCuenta.Text = "CONFIGURAR CUENTA";
            btnConfigCuenta.UseVisualStyleBackColor = false;
            btnConfigCuenta.Click += btnConfigCuenta_Click;
            // 
            // labelCuenta
            // 
            labelCuenta.AutoSize = true;
            labelCuenta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCuenta.Location = new Point(298, 75);
            labelCuenta.Name = "labelCuenta";
            labelCuenta.Size = new Size(77, 15);
            labelCuenta.TabIndex = 15;
            labelCuenta.Text = "N de cuenta:";
            // 
            // textBoxNumeroCuenta
            // 
            textBoxNumeroCuenta.BackColor = SystemColors.GradientActiveCaption;
            textBoxNumeroCuenta.ForeColor = SystemColors.Window;
            textBoxNumeroCuenta.Location = new Point(381, 72);
            textBoxNumeroCuenta.Name = "textBoxNumeroCuenta";
            textBoxNumeroCuenta.ReadOnly = true;
            textBoxNumeroCuenta.Size = new Size(179, 23);
            textBoxNumeroCuenta.TabIndex = 16;
            // 
            // AgregarEmpController
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxNumeroCuenta);
            Controls.Add(labelCuenta);
            Controls.Add(btnConfigCuenta);
            Controls.Add(checkedListRetenciones);
            Controls.Add(label1);
            Controls.Add(btnCrearEmp);
            Controls.Add(labelTitulo);
            Controls.Add(labelFechaIng);
            Controls.Add(labelNaci);
            Controls.Add(labelApellidos);
            Controls.Add(labelNom);
            Controls.Add(labelDni);
            Controls.Add(fechaNacimiento);
            Controls.Add(fechaIngreso);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDni);
            Name = "AgregarEmpController";
            Size = new Size(565, 346);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDni;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private DateTimePicker fechaIngreso;
        private DateTimePicker fechaNacimiento;
        private Label labelDni;
        private Label labelNom;
        private Label labelApellidos;
        private Label labelNaci;
        private Label labelFechaIng;
        private Label labelTitulo;
        private Button btnCrearEmp;
        private Label label1;
        private CheckedListBox checkedListRetenciones;
        private Button btnConfigCuenta;
        private Label labelCuenta;
        private TextBox textBoxNumeroCuenta;
    }
}
