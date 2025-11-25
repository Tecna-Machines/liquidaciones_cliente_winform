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
            textBoxMontoBanco = new TextBox();
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
            columnPorcentual = new ColumnHeader();
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
            labelDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(15, 34);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(44, 21);
            labelDni.TabIndex = 1;
            labelDni.Text = "DNI:";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(6, 78);
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
            groupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox.Location = new Point(313, 71);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(475, 141);
            groupBox.TabIndex = 3;
            groupBox.TabStop = false;
            groupBox.Text = "DATOS EMPLEADO";
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.ButtonHighlight;
            textBoxNombre.Location = new Point(95, 80);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(374, 23);
            textBoxNombre.TabIndex = 4;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Location = new Point(74, 34);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(395, 23);
            textBoxDni.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(comboBoxModalidad);
            groupBox1.Controls.Add(textBoxMontoBanco);
            groupBox1.Controls.Add(textBoxValorHora);
            groupBox1.Controls.Add(textBoxSueldo);
            groupBox1.Controls.Add(textBoxValorBlanco);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(313, 237);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(475, 143);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "DATOS ACUERDO";
            // 
            // comboBoxModalidad
            // 
            comboBoxModalidad.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxModalidad.FormattingEnabled = true;
            comboBoxModalidad.Location = new Point(85, 83);
            comboBoxModalidad.Name = "comboBoxModalidad";
            comboBoxModalidad.Size = new Size(147, 23);
            comboBoxModalidad.TabIndex = 7;
            // 
            // textBoxMontoBanco
            // 
            textBoxMontoBanco.Location = new Point(354, 83);
            textBoxMontoBanco.Name = "textBoxMontoBanco";
            textBoxMontoBanco.Size = new Size(115, 23);
            textBoxMontoBanco.TabIndex = 6;
            textBoxMontoBanco.TextChanged += TextBoxMontoFijo_TextChanged;
            // 
            // textBoxValorHora
            // 
            textBoxValorHora.Location = new Point(354, 41);
            textBoxValorHora.Name = "textBoxValorHora";
            textBoxValorHora.Size = new Size(115, 23);
            textBoxValorHora.TabIndex = 5;
            // 
            // textBoxSueldo
            // 
            textBoxSueldo.Location = new Point(85, 38);
            textBoxSueldo.Name = "textBoxSueldo";
            textBoxSueldo.Size = new Size(147, 23);
            textBoxSueldo.TabIndex = 4;
            textBoxSueldo.TextChanged += TextBoxMontoFijo_TextChanged;
            // 
            // textBoxValorBlanco
            // 
            textBoxValorBlanco.AutoSize = true;
            textBoxValorBlanco.Location = new Point(238, 86);
            textBoxValorBlanco.Name = "textBoxValorBlanco";
            textBoxValorBlanco.Size = new Size(98, 15);
            textBoxValorBlanco.TabIndex = 3;
            textBoxValorBlanco.Text = "VALOR BLANCO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(43, 91);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 2;
            label3.Text = "TIPO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(254, 44);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 1;
            label2.Text = "VALOR HORA:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 44);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "SUELDO:";
            // 
            // groupBoxAdicionales
            // 
            groupBoxAdicionales.Controls.Add(listAdicionales);
            groupBoxAdicionales.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxAdicionales.Location = new Point(313, 395);
            groupBoxAdicionales.Name = "groupBoxAdicionales";
            groupBoxAdicionales.Size = new Size(475, 172);
            groupBoxAdicionales.TabIndex = 6;
            groupBoxAdicionales.TabStop = false;
            groupBoxAdicionales.Text = "ADICIONALES";
            // 
            // listAdicionales
            // 
            listAdicionales.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnMonto, columnBlanco, columnPorcentual });
            listAdicionales.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAdicionales.Location = new Point(15, 22);
            listAdicionales.Name = "listAdicionales";
            listAdicionales.Size = new Size(454, 132);
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
            columnMonto.Text = "MONTO";
            columnMonto.Width = 80;
            // 
            // columnBlanco
            // 
            columnBlanco.Text = "BLANCO";
            columnBlanco.Width = 80;
            // 
            // columnPorcentual
            // 
            columnPorcentual.Text = "PORCENTUAL";
            columnPorcentual.Width = 90;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(409, 29);
            label5.Name = "label5";
            label5.Size = new Size(283, 25);
            label5.TabIndex = 7;
            label5.Text = "CREAR ACUERDO DE TRABAJO";
            // 
            // btnConfirmarContrato
            // 
            btnConfirmarContrato.BackColor = Color.PaleGreen;
            btnConfirmarContrato.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarContrato.Location = new Point(514, 590);
            btnConfirmarContrato.Name = "btnConfirmarContrato";
            btnConfirmarContrato.Size = new Size(178, 43);
            btnConfirmarContrato.TabIndex = 8;
            btnConfirmarContrato.Text = "CONTINUAR";
            btnConfirmarContrato.UseVisualStyleBackColor = false;
            btnConfirmarContrato.Click += BtnConfirmarContrato_Click;
            // 
            // BtnAgregarAdicional
            // 
            BtnAgregarAdicional.BackColor = Color.SkyBlue;
            BtnAgregarAdicional.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregarAdicional.Location = new Point(313, 590);
            BtnAgregarAdicional.Name = "BtnAgregarAdicional";
            BtnAgregarAdicional.Size = new Size(178, 43);
            BtnAgregarAdicional.TabIndex = 9;
            BtnAgregarAdicional.Text = "AGREGAR ADICIONAL";
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
            groupBoxRetenciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxRetenciones.Location = new Point(806, 82);
            groupBoxRetenciones.Name = "groupBoxRetenciones";
            groupBoxRetenciones.Size = new Size(361, 485);
            groupBoxRetenciones.TabIndex = 7;
            groupBoxRetenciones.TabStop = false;
            groupBoxRetenciones.Text = "RETENCIONES";
            // 
            // listRetenciones
            // 
            listRetenciones.CheckBoxes = true;
            listRetenciones.Columns.AddRange(new ColumnHeader[] { columnSeleccionado, columnCodigo, columnConcepto, columnValor, columnQuincena });
            listRetenciones.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listRetenciones.Location = new Point(15, 22);
            listRetenciones.Name = "listRetenciones";
            listRetenciones.Size = new Size(340, 445);
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
            columnCodigo.Text = "Codigo";
            columnCodigo.Width = 65;
            // 
            // columnConcepto
            // 
            columnConcepto.Text = "Concepto";
            columnConcepto.Width = 80;
            // 
            // columnValor
            // 
            columnValor.Text = "Valor";
            columnValor.Width = 80;
            // 
            // columnQuincena
            // 
            columnQuincena.Text = "Quincena";
            columnQuincena.Width = 65;
            // 
            // CrearAcuerdoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1179, 706);
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
        private TextBox textBoxMontoBanco;
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
        private ColumnHeader columnPorcentual;
        private GroupBox groupBoxRetenciones;
        private ListView listRetenciones;
        private ColumnHeader columnSeleccionado;
        private ColumnHeader columnCodigo;
        private ColumnHeader columnConcepto;
        private ColumnHeader columnValor;
        private ColumnHeader columnQuincena;
    }
}