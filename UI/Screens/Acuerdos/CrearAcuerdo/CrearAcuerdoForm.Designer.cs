namespace UI.Screens.CrearContrato
{
    partial class CrearAcuerdoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearAcuerdoForm));
            labelDni = new Label();
            labelNombre = new Label();
            groupBox = new GroupBox();
            textBoxNombre = new TextBox();
            textBoxDni = new TextBox();
            groupBox1 = new GroupBox();
            comboBoxModalidad = new ComboBox();
            textBoxMontoSueldoJornal = new TextBox();
            textBoxValorHora = new TextBox();
            textBoxSueldo = new TextBox();
            textBoxValorBlanco = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBoxAdicionales = new GroupBox();
            listAdicionales = new ListView();
            columnDescripcion = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnBlanco = new ColumnHeader();
            label5 = new Label();
            btnConfirmarContrato = new Button();
            BtnAgregarAdicional = new Button();
            listaEmpComponent1 = new UI.Components.Utils.ListaEmpComponent();
            groupBoxRetenciones = new GroupBox();
            listRetenciones = new ListView();
            columnSeleccionado = new ColumnHeader();
            columnCodigo = new ColumnHeader();
            columnConcepto = new ColumnHeader();
            columnValor = new ColumnHeader();
            columnQuincena = new ColumnHeader();
            groupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxAdicionales.SuspendLayout();
            groupBoxRetenciones.SuspendLayout();
            SuspendLayout();
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelDni.Location = new Point(15, 34);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(44, 21);
            labelDni.TabIndex = 1;
            labelDni.Text = "DNI:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            labelNombre.Location = new Point(270, 34);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(83, 21);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "NOMBRE:";
            // 
            // groupBox
            // 
            groupBox.Controls.Add(textBoxNombre);
            groupBox.Controls.Add(textBoxDni);
            groupBox.Controls.Add(labelDni);
            groupBox.Controls.Add(labelNombre);
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox.Location = new Point(313, 71);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(842, 78);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "DATOS EMPLEADO";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.ButtonHighlight;
            textBoxNombre.Location = new Point(366, 33);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(456, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Location = new Point(72, 33);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(185, 23);
            textBoxDni.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxModalidad);
            groupBox1.Controls.Add(textBoxMontoSueldoJornal);
            groupBox1.Controls.Add(textBoxValorHora);
            groupBox1.Controls.Add(textBoxSueldo);
            groupBox1.Controls.Add(textBoxValorBlanco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(313, 172);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(842, 123);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS ACUERDO";
            // 
            // comboBoxModalidad
            // 
            comboBoxModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModalidad.FormattingEnabled = true;
            comboBoxModalidad.Location = new Point(431, 40);
            comboBoxModalidad.Name = "comboBoxModalidad";
            comboBoxModalidad.Size = new Size(319, 23);
            comboBoxModalidad.TabIndex = 7;
            // 
            // textBoxMontoSueldoJornal
            // 
            textBoxMontoSueldoJornal.Location = new Point(149, 81);
            textBoxMontoSueldoJornal.Name = "textBoxMontoSueldoJornal";
            textBoxMontoSueldoJornal.Size = new Size(158, 23);
            textBoxMontoSueldoJornal.TabIndex = 6;
            textBoxMontoSueldoJornal.TextChanged += TextBoxMontoFijo_TextChanged;
            // 
            // textBoxValorHora
            // 
            textBoxValorHora.ForeColor = Color.ForestGreen;
            textBoxValorHora.Location = new Point(431, 81);
            textBoxValorHora.Name = "textBoxValorHora";
            textBoxValorHora.Size = new Size(97, 23);
            textBoxValorHora.TabIndex = 5;
            textBoxValorHora.Text = "0";
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(149, 40);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.Size = new Size(158, 23);
            textBoxSueldo.TabIndex = 4;
            textBoxSueldo.TextChanged += TextBoxMontoFijo_TextChanged;
            // 
            // textBoxValorBlanco
            // 
            textBoxValorBlanco.AutoSize = true;
            textBoxValorBlanco.Location = new Point(15, 84);
            textBoxValorBlanco.Name = "textBoxValorBlanco";
            textBoxValorBlanco.Size = new Size(115, 15);
            textBoxValorBlanco.TabIndex = 3;
            textBoxValorBlanco.Text = "SUELDO / JORNAL :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(326, 44);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "TIPO SUELDO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(327, 85);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "VALOR HORA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 44);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 0;
            label1.Text = "SUELDO MENSUAL:";
            // 
            // groupBoxAdicionales
            // 
            groupBoxAdicionales.Controls.Add(listAdicionales);
            groupBoxAdicionales.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxAdicionales.Location = new Point(313, 508);
            groupBoxAdicionales.Name = "groupBoxAdicionales";
            groupBoxAdicionales.Size = new Size(551, 172);
            groupBoxAdicionales.TabIndex = 6;
            groupBoxAdicionales.TabStop = false;
            groupBoxAdicionales.Text = "ADICIONALES";
            // 
            // listAdicionales
            // 
            listAdicionales.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnMonto, columnBlanco });
            listAdicionales.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAdicionales.Location = new Point(15, 22);
            listAdicionales.Name = "listAdicionales";
            listAdicionales.Size = new Size(513, 127);
            listAdicionales.TabIndex = 0;
            listAdicionales.UseCompatibleStateImageBehavior = false;
            listAdicionales.View = View.Details;
            listAdicionales.MouseDoubleClick += EliminarAdicional_DobleClick;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "DESCRIPCION";
            columnDescripcion.Width = 200;
            // 
            // columnMonto
            // 
            columnMonto.Text = "MONTO / PORCENTAJE";
            columnMonto.Width = 150;
            // 
            // columnBlanco
            // 
            columnBlanco.Text = "INTERNO / OFICIAL";
            columnBlanco.Width = 150;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(409, 29);
            label5.Name = "label5";
            label5.Size = new Size(283, 25);
            label5.TabIndex = 7;
            label5.Text = "CREAR ACUERDO DE TRABAJO";
            // 
            // btnConfirmarContrato
            // 
            btnConfirmarContrato.BackColor = Color.PaleGreen;
            btnConfirmarContrato.Cursor = Cursors.Hand;
            btnConfirmarContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarContrato.Location = new Point(885, 567);
            btnConfirmarContrato.Name = "btnConfirmarContrato";
            btnConfirmarContrato.Size = new Size(178, 43);
            btnConfirmarContrato.TabIndex = 8;
            btnConfirmarContrato.Text = "CARGAR ACUERDO";
            btnConfirmarContrato.UseVisualStyleBackColor = false;
            btnConfirmarContrato.Click += BtnConfirmarContrato_Click;
            // 
            // BtnAgregarAdicional
            // 
            BtnAgregarAdicional.BackColor = Color.SkyBlue;
            BtnAgregarAdicional.Cursor = Cursors.Hand;
            BtnAgregarAdicional.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            BtnAgregarAdicional.Location = new Point(885, 518);
            BtnAgregarAdicional.Name = "BtnAgregarAdicional";
            BtnAgregarAdicional.Size = new Size(178, 43);
            BtnAgregarAdicional.TabIndex = 9;
            BtnAgregarAdicional.Text = "AGREGAR EXTRA PLUS";
            BtnAgregarAdicional.UseVisualStyleBackColor = false;
            BtnAgregarAdicional.Click += BtnAgregarAdicional_Click;
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(3, 4);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.ServiceProvider = null;
            listaEmpComponent1.Size = new Size(304, 690);
            listaEmpComponent1.TabIndex = 10;
            // 
            // groupBoxRetenciones
            // 
            groupBoxRetenciones.Controls.Add(listRetenciones);
            groupBoxRetenciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxRetenciones.Location = new Point(313, 310);
            groupBoxRetenciones.Name = "groupBoxRetenciones";
            groupBoxRetenciones.Size = new Size(842, 183);
            groupBoxRetenciones.TabIndex = 7;
            groupBoxRetenciones.TabStop = false;
            groupBoxRetenciones.Text = "RETENCIONES QUE SE APLICARAN";
            // 
            // listRetenciones
            // 
            listRetenciones.CheckBoxes = true;
            listRetenciones.Columns.AddRange(new ColumnHeader[] { columnSeleccionado, columnCodigo, columnConcepto, columnValor, columnQuincena });
            listRetenciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listRetenciones.Location = new Point(15, 22);
            listRetenciones.Name = "listRetenciones";
            listRetenciones.Size = new Size(807, 143);
            listRetenciones.TabIndex = 0;
            listRetenciones.UseCompatibleStateImageBehavior = false;
            listRetenciones.View = View.Details;
            // 
            // columnSeleccionado
            // 
            columnSeleccionado.Text = "#";
            columnSeleccionado.Width = 20;
            // 
            // columnCodigo
            // 
            columnCodigo.Text = "CODIGO";
            columnCodigo.Width = 70;
            // 
            // columnConcepto
            // 
            columnConcepto.Text = "CONCEPTO";
            columnConcepto.Width = 200;
            // 
            // columnValor
            // 
            columnValor.Text = "MONTO / PORCENTAJE";
            columnValor.Width = 150;
            // 
            // columnQuincena
            // 
            columnQuincena.Text = "QUINCENA EN CUAL DESCONTAR";
            columnQuincena.Width = 200;
            // 
            // CrearAcuerdoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 692);
            Controls.Add(groupBoxRetenciones);
            Controls.Add(listaEmpComponent1);
            Controls.Add(BtnAgregarAdicional);
            Controls.Add(btnConfirmarContrato);
            Controls.Add(label5);
            Controls.Add(groupBoxAdicionales);
            Controls.Add(groupBox1);
            Controls.Add(groupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CrearAcuerdoForm";
            ShowInTaskbar = false;
            Text = "CrearContratoForm";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxAdicionales.ResumeLayout(false);
            groupBoxRetenciones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDni;
        private Label labelNombre;
        private GroupBox groupBox;
        private TextBox textBoxNombre;
        private TextBox textBoxDni;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxModalidad;
        private TextBox textBoxMontoSueldoJornal;
        private TextBox textBoxValorHora;
        private TextBox textBoxSueldo;
        private Label textBoxValorBlanco;
        private Label label3;
        private GroupBox groupBoxAdicionales;
        private Label label5;
        private Button btnConfirmarContrato;
        private Button BtnAgregarAdicional;
        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private ListView listAdicionales;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnMonto;
        private ColumnHeader columnBlanco;
        private GroupBox groupBoxRetenciones;
        private ListView listRetenciones;
        private ColumnHeader columnSeleccionado;
        private ColumnHeader columnCodigo;
        private ColumnHeader columnConcepto;
        private ColumnHeader columnValor;
        private ColumnHeader columnQuincena;
    }
}