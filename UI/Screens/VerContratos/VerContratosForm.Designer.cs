namespace UI.Screens.VerContratos
{
    partial class VerContratosForm
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
            listaEmpComponent1 = new Components.Utils.ListaEmpComponent();
            groupBoxEmpleado = new GroupBox();
            textBoxFechaCarga = new TextBox();
            textBoxFechaNacimiento = new TextBox();
            textBoxFechaIngreso = new TextBox();
            textBoxApellidos = new TextBox();
            textBoxNombres = new TextBox();
            textBoxDni = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            textBoxMontoBrutoBanco = new TextBox();
            textBoxMontoValorHora = new TextBox();
            textBoxMontoBrutoEfectiv = new TextBox();
            textBoxMontoBrutoFijo = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            groupBox2 = new GroupBox();
            textBoxFechaCreacionContrato = new TextBox();
            textBoxModalidad = new TextBox();
            textBoxCodigoContrato = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBoxHistorial = new GroupBox();
            listHistorial = new ListView();
            columnHeaderCod = new ColumnHeader();
            columnHeaderMonto = new ColumnHeader();
            columnHeaderMontHs = new ColumnHeader();
            columnHeaderFech = new ColumnHeader();
            groupBoxEmpleado.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBoxHistorial.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpComponent1
            // 
            listaEmpComponent1.Location = new Point(12, 12);
            listaEmpComponent1.Name = "listaEmpComponent1";
            listaEmpComponent1.Size = new Size(304, 690);
            listaEmpComponent1.TabIndex = 0;
            // 
            // groupBoxEmpleado
            // 
            groupBoxEmpleado.Controls.Add(textBoxFechaCarga);
            groupBoxEmpleado.Controls.Add(textBoxFechaNacimiento);
            groupBoxEmpleado.Controls.Add(textBoxFechaIngreso);
            groupBoxEmpleado.Controls.Add(textBoxApellidos);
            groupBoxEmpleado.Controls.Add(textBoxNombres);
            groupBoxEmpleado.Controls.Add(textBoxDni);
            groupBoxEmpleado.Controls.Add(label9);
            groupBoxEmpleado.Controls.Add(label8);
            groupBoxEmpleado.Controls.Add(label7);
            groupBoxEmpleado.Controls.Add(label6);
            groupBoxEmpleado.Controls.Add(label5);
            groupBoxEmpleado.Controls.Add(label4);
            groupBoxEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEmpleado.Location = new Point(322, 218);
            groupBoxEmpleado.Name = "groupBoxEmpleado";
            groupBoxEmpleado.Size = new Size(598, 122);
            groupBoxEmpleado.TabIndex = 1;
            groupBoxEmpleado.TabStop = false;
            groupBoxEmpleado.Text = "datos empleado";
            // 
            // textBoxFechaCarga
            // 
            textBoxFechaCarga.BackColor = SystemColors.ButtonHighlight;
            textBoxFechaCarga.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFechaCarga.Location = new Point(414, 88);
            textBoxFechaCarga.Name = "textBoxFechaCarga";
            textBoxFechaCarga.ReadOnly = true;
            textBoxFechaCarga.Size = new Size(168, 23);
            textBoxFechaCarga.TabIndex = 15;
            // 
            // textBoxFechaNacimiento
            // 
            textBoxFechaNacimiento.BackColor = SystemColors.ButtonHighlight;
            textBoxFechaNacimiento.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFechaNacimiento.Location = new Point(414, 59);
            textBoxFechaNacimiento.Name = "textBoxFechaNacimiento";
            textBoxFechaNacimiento.ReadOnly = true;
            textBoxFechaNacimiento.Size = new Size(168, 23);
            textBoxFechaNacimiento.TabIndex = 14;
            // 
            // textBoxFechaIngreso
            // 
            textBoxFechaIngreso.BackColor = SystemColors.ButtonHighlight;
            textBoxFechaIngreso.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFechaIngreso.Location = new Point(414, 30);
            textBoxFechaIngreso.Name = "textBoxFechaIngreso";
            textBoxFechaIngreso.ReadOnly = true;
            textBoxFechaIngreso.Size = new Size(168, 23);
            textBoxFechaIngreso.TabIndex = 13;
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.BackColor = SystemColors.ButtonHighlight;
            textBoxApellidos.ForeColor = SystemColors.ActiveCaptionText;
            textBoxApellidos.Location = new Point(81, 88);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.ReadOnly = true;
            textBoxApellidos.Size = new Size(178, 23);
            textBoxApellidos.TabIndex = 12;
            // 
            // textBoxNombres
            // 
            textBoxNombres.BackColor = SystemColors.ButtonHighlight;
            textBoxNombres.ForeColor = SystemColors.ActiveCaptionText;
            textBoxNombres.Location = new Point(81, 59);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.ReadOnly = true;
            textBoxNombres.Size = new Size(178, 23);
            textBoxNombres.TabIndex = 11;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.ForeColor = SystemColors.ActiveCaptionText;
            textBoxDni.Location = new Point(81, 30);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(178, 23);
            textBoxDni.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(335, 88);
            label9.Name = "label9";
            label9.Size = new Size(75, 15);
            label9.TabIndex = 9;
            label9.Text = "Fecha carga:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(301, 62);
            label8.Name = "label8";
            label8.Size = new Size(109, 15);
            label8.TabIndex = 8;
            label8.Text = "Fecha Nacimiento:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(324, 33);
            label7.Name = "label7";
            label7.Size = new Size(86, 15);
            label7.TabIndex = 7;
            label7.Text = "Fecha ingreso:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 91);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 6;
            label6.Text = "Apellido/s:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 67);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 5;
            label5.Text = "Nombre/s:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 33);
            label4.Name = "label4";
            label4.Size = new Size(27, 15);
            label4.TabIndex = 4;
            label4.Text = "dni:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxMontoBrutoBanco);
            groupBox1.Controls.Add(textBoxMontoValorHora);
            groupBox1.Controls.Add(textBoxMontoBrutoEfectiv);
            groupBox1.Controls.Add(textBoxMontoBrutoFijo);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(328, 463);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(598, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "datos sobre montos";
            // 
            // textBoxMontoBrutoBanco
            // 
            textBoxMontoBrutoBanco.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoBrutoBanco.ForeColor = SystemColors.ActiveCaptionText;
            textBoxMontoBrutoBanco.Location = new Point(426, 58);
            textBoxMontoBrutoBanco.Name = "textBoxMontoBrutoBanco";
            textBoxMontoBrutoBanco.ReadOnly = true;
            textBoxMontoBrutoBanco.Size = new Size(102, 23);
            textBoxMontoBrutoBanco.TabIndex = 22;
            // 
            // textBoxMontoValorHora
            // 
            textBoxMontoValorHora.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoValorHora.ForeColor = SystemColors.ActiveCaptionText;
            textBoxMontoValorHora.Location = new Point(426, 28);
            textBoxMontoValorHora.Name = "textBoxMontoValorHora";
            textBoxMontoValorHora.ReadOnly = true;
            textBoxMontoValorHora.Size = new Size(102, 23);
            textBoxMontoValorHora.TabIndex = 21;
            // 
            // textBoxMontoBrutoEfectiv
            // 
            textBoxMontoBrutoEfectiv.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoBrutoEfectiv.ForeColor = SystemColors.ActiveCaptionText;
            textBoxMontoBrutoEfectiv.Location = new Point(170, 58);
            textBoxMontoBrutoEfectiv.Name = "textBoxMontoBrutoEfectiv";
            textBoxMontoBrutoEfectiv.ReadOnly = true;
            textBoxMontoBrutoEfectiv.Size = new Size(102, 23);
            textBoxMontoBrutoEfectiv.TabIndex = 20;
            // 
            // textBoxMontoBrutoFijo
            // 
            textBoxMontoBrutoFijo.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoBrutoFijo.ForeColor = SystemColors.ActiveCaptionText;
            textBoxMontoBrutoFijo.Location = new Point(170, 28);
            textBoxMontoBrutoFijo.Name = "textBoxMontoBrutoFijo";
            textBoxMontoBrutoFijo.ReadOnly = true;
            textBoxMontoBrutoFijo.Size = new Size(102, 23);
            textBoxMontoBrutoFijo.TabIndex = 19;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(354, 31);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 7;
            label13.Text = "valor hora:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(295, 61);
            label12.Name = "label12";
            label12.Size = new Size(125, 15);
            label12.TabIndex = 6;
            label12.Text = "monto bruto (banco):";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(25, 58);
            label11.Name = "label11";
            label11.Size = new Size(139, 15);
            label11.TabIndex = 5;
            label11.Text = "monto bruto (efectivo):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 31);
            label10.Name = "label10";
            label10.Size = new Size(102, 15);
            label10.TabIndex = 4;
            label10.Text = "monto bruto fijo:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxFechaCreacionContrato);
            groupBox2.Controls.Add(textBoxModalidad);
            groupBox2.Controls.Add(textBoxCodigoContrato);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(322, 358);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(598, 78);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "datos del acuerdo";
            // 
            // textBoxFechaCreacionContrato
            // 
            textBoxFechaCreacionContrato.BackColor = SystemColors.ButtonHighlight;
            textBoxFechaCreacionContrato.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFechaCreacionContrato.Location = new Point(490, 35);
            textBoxFechaCreacionContrato.Name = "textBoxFechaCreacionContrato";
            textBoxFechaCreacionContrato.ReadOnly = true;
            textBoxFechaCreacionContrato.Size = new Size(102, 23);
            textBoxFechaCreacionContrato.TabIndex = 18;
            // 
            // textBoxModalidad
            // 
            textBoxModalidad.BackColor = SystemColors.ButtonHighlight;
            textBoxModalidad.ForeColor = SystemColors.ActiveCaptionText;
            textBoxModalidad.Location = new Point(240, 35);
            textBoxModalidad.Name = "textBoxModalidad";
            textBoxModalidad.ReadOnly = true;
            textBoxModalidad.Size = new Size(130, 23);
            textBoxModalidad.TabIndex = 17;
            // 
            // textBoxCodigoContrato
            // 
            textBoxCodigoContrato.BackColor = SystemColors.ButtonHighlight;
            textBoxCodigoContrato.ForeColor = SystemColors.ActiveCaptionText;
            textBoxCodigoContrato.Location = new Point(59, 35);
            textBoxCodigoContrato.Name = "textBoxCodigoContrato";
            textBoxCodigoContrato.ReadOnly = true;
            textBoxCodigoContrato.Size = new Size(102, 23);
            textBoxCodigoContrato.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(376, 38);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 1;
            label2.Text = "fecha de creacion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 3;
            label3.Text = "codigo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 38);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "modalidad:";
            // 
            // groupBoxHistorial
            // 
            groupBoxHistorial.Controls.Add(listHistorial);
            groupBoxHistorial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxHistorial.Location = new Point(322, 47);
            groupBoxHistorial.Name = "groupBoxHistorial";
            groupBoxHistorial.Size = new Size(598, 157);
            groupBoxHistorial.TabIndex = 2;
            groupBoxHistorial.TabStop = false;
            groupBoxHistorial.Text = "historial  de contratos";
            // 
            // listHistorial
            // 
            listHistorial.BackColor = SystemColors.Window;
            listHistorial.BorderStyle = BorderStyle.FixedSingle;
            listHistorial.Columns.AddRange(new ColumnHeader[] { columnHeaderCod, columnHeaderMonto, columnHeaderMontHs, columnHeaderFech });
            listHistorial.ForeColor = SystemColors.ControlText;
            listHistorial.FullRowSelect = true;
            listHistorial.GridLines = true;
            listHistorial.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listHistorial.Location = new Point(6, 22);
            listHistorial.Name = "listHistorial";
            listHistorial.Size = new Size(586, 129);
            listHistorial.TabIndex = 0;
            listHistorial.UseCompatibleStateImageBehavior = false;
            listHistorial.View = View.Details;
            listHistorial.SelectedIndexChanged += listHistorial_SelectedIndexChanged;
            // 
            // columnHeaderCod
            // 
            columnHeaderCod.Text = "Codigo";
            columnHeaderCod.Width = 100;
            // 
            // columnHeaderMonto
            // 
            columnHeaderMonto.Text = "Monto Fijo";
            columnHeaderMonto.Width = 100;
            // 
            // columnHeaderMontHs
            // 
            columnHeaderMontHs.Text = "Monto Hora";
            columnHeaderMontHs.Width = 100;
            // 
            // columnHeaderFech
            // 
            columnHeaderFech.Text = "Fecha";
            columnHeaderFech.Width = 100;
            // 
            // VerContratosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 703);
            Controls.Add(groupBoxHistorial);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxEmpleado);
            Controls.Add(listaEmpComponent1);
            Name = "VerContratosForm";
            Text = "VerContratosForm";
            groupBoxEmpleado.ResumeLayout(false);
            groupBoxEmpleado.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxHistorial.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Components.Utils.ListaEmpComponent listaEmpComponent1;
        private GroupBox groupBoxEmpleado;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBoxHistorial;
        private ListView listHistorial;
        private ColumnHeader columnHeaderCod;
        private ColumnHeader columnHeaderMonto;
        private ColumnHeader columnHeaderMontHs;
        private ColumnHeader columnHeaderFech;
        private Label label2;
        private Label label3;
        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox textBoxDni;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private TextBox textBoxFechaCarga;
        private TextBox textBoxFechaNacimiento;
        private TextBox textBoxFechaIngreso;
        private TextBox textBoxApellidos;
        private TextBox textBoxNombres;
        private TextBox textBoxFechaCreacionContrato;
        private TextBox textBoxModalidad;
        private TextBox textBoxCodigoContrato;
        private TextBox textBoxMontoBrutoBanco;
        private TextBox textBoxMontoValorHora;
        private TextBox textBoxMontoBrutoEfectiv;
        private TextBox textBoxMontoBrutoFijo;
    }
}