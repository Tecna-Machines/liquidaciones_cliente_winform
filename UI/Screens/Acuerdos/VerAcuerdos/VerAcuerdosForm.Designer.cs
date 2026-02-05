namespace UI.Screens.VerContratos
{
    partial class VerAcuerdosForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerAcuerdosForm));
            groupBox2 = new GroupBox();
            textBoxFechaAcuerdo = new TextBox();
            textBoxValorBlanco = new TextBox();
            textBoxValorSueldo = new TextBox();
            textBoxValorHora = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            textBoxTipoSueldo = new TextBox();
            textBoxCodAcuerdo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            groupBoxHistorial = new GroupBox();
            listHistorial = new ListView();
            columnHeaderCod = new ColumnHeader();
            columnHeaderMonto = new ColumnHeader();
            columnHeaderMontHs = new ColumnHeader();
            columnHeaderFech = new ColumnHeader();
            groupBoxEmpleado = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            textBoxNombre = new TextBox();
            textBoxDni = new TextBox();
            groupBox1 = new GroupBox();
            listAdicionales = new ListView();
            columnDescripcion = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnBlanco = new ColumnHeader();
            columnPorcentual = new ColumnHeader();
            listaEmpleados = new UI.Components.Utils.ListaEmpComponent();
            groupBox2.SuspendLayout();
            groupBoxHistorial.SuspendLayout();
            groupBoxEmpleado.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxFechaAcuerdo);
            groupBox2.Controls.Add(textBoxValorBlanco);
            groupBox2.Controls.Add(textBoxValorSueldo);
            groupBox2.Controls.Add(textBoxValorHora);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(textBoxTipoSueldo);
            groupBox2.Controls.Add(textBoxCodAcuerdo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(322, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 154);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "DETALLE ACUERDO:";
            // 
            // textBoxFechaAcuerdo
            // 
            textBoxFechaAcuerdo.BackColor = SystemColors.ButtonHighlight;
            textBoxFechaAcuerdo.ForeColor = SystemColors.ActiveCaptionText;
            textBoxFechaAcuerdo.Location = new Point(72, 102);
            textBoxFechaAcuerdo.Name = "textBoxFechaAcuerdo";
            textBoxFechaAcuerdo.ReadOnly = true;
            textBoxFechaAcuerdo.Size = new Size(202, 23);
            textBoxFechaAcuerdo.TabIndex = 27;
            // 
            // textBoxValorBlanco
            // 
            textBoxValorBlanco.BackColor = SystemColors.ButtonHighlight;
            textBoxValorBlanco.ForeColor = SystemColors.ActiveCaptionText;
            textBoxValorBlanco.Location = new Point(413, 102);
            textBoxValorBlanco.Name = "textBoxValorBlanco";
            textBoxValorBlanco.ReadOnly = true;
            textBoxValorBlanco.Size = new Size(149, 23);
            textBoxValorBlanco.TabIndex = 24;
            // 
            // textBoxValorSueldo
            // 
            textBoxValorSueldo.BackColor = SystemColors.ButtonHighlight;
            textBoxValorSueldo.ForeColor = SystemColors.ActiveCaptionText;
            textBoxValorSueldo.Location = new Point(413, 68);
            textBoxValorSueldo.Name = "textBoxValorSueldo";
            textBoxValorSueldo.ReadOnly = true;
            textBoxValorSueldo.Size = new Size(149, 23);
            textBoxValorSueldo.TabIndex = 23;
            // 
            // textBoxValorHora
            // 
            textBoxValorHora.BackColor = SystemColors.ButtonHighlight;
            textBoxValorHora.ForeColor = SystemColors.ActiveCaptionText;
            textBoxValorHora.Location = new Point(413, 34);
            textBoxValorHora.Name = "textBoxValorHora";
            textBoxValorHora.ReadOnly = true;
            textBoxValorHora.Size = new Size(149, 23);
            textBoxValorHora.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(310, 70);
            label6.Name = "label6";
            label6.Size = new Size(97, 15);
            label6.TabIndex = 21;
            label6.Text = "VALOR SUELDO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(309, 106);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 20;
            label5.Text = "VALOR OFICIAL:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(322, 38);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 19;
            label4.Text = "VALOR HORA:";
            // 
            // textBoxTipoSueldo
            // 
            textBoxTipoSueldo.BackColor = SystemColors.ButtonHighlight;
            textBoxTipoSueldo.ForeColor = SystemColors.ActiveCaptionText;
            textBoxTipoSueldo.Location = new Point(72, 68);
            textBoxTipoSueldo.Name = "textBoxTipoSueldo";
            textBoxTipoSueldo.ReadOnly = true;
            textBoxTipoSueldo.Size = new Size(202, 23);
            textBoxTipoSueldo.TabIndex = 17;
            // 
            // textBoxCodAcuerdo
            // 
            textBoxCodAcuerdo.BackColor = SystemColors.ButtonHighlight;
            textBoxCodAcuerdo.ForeColor = SystemColors.ActiveCaptionText;
            textBoxCodAcuerdo.Location = new Point(72, 34);
            textBoxCodAcuerdo.Name = "textBoxCodAcuerdo";
            textBoxCodAcuerdo.ReadOnly = true;
            textBoxCodAcuerdo.Size = new Size(202, 23);
            textBoxCodAcuerdo.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 106);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 1;
            label2.Text = "FECHA:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 3;
            label3.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 70);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 0;
            label1.Text = "TIPO:";
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
            groupBoxHistorial.Text = "HISTORIAL ";
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
            listHistorial.SelectedIndexChanged += Select_AcuerdoDeHistorial;
            // 
            // columnHeaderCod
            // 
            columnHeaderCod.Text = "CODIGO";
            columnHeaderCod.Width = 100;
            // 
            // columnHeaderMonto
            // 
            columnHeaderMonto.Text = "SUELDO";
            columnHeaderMonto.Width = 100;
            // 
            // columnHeaderMontHs
            // 
            columnHeaderMontHs.Text = "VALOR HORA";
            columnHeaderMontHs.Width = 100;
            // 
            // columnHeaderFech
            // 
            columnHeaderFech.Text = "FECHA";
            columnHeaderFech.Width = 100;
            // 
            // groupBoxEmpleado
            // 
            groupBoxEmpleado.Controls.Add(label8);
            groupBoxEmpleado.Controls.Add(label7);
            groupBoxEmpleado.Controls.Add(textBoxNombre);
            groupBoxEmpleado.Controls.Add(textBoxDni);
            groupBoxEmpleado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxEmpleado.Location = new Point(322, 219);
            groupBoxEmpleado.Name = "groupBoxEmpleado";
            groupBoxEmpleado.Size = new Size(598, 58);
            groupBoxEmpleado.TabIndex = 3;
            groupBoxEmpleado.TabStop = false;
            groupBoxEmpleado.Text = "DETALLE EMPLEADO:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(213, 29);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 3;
            label8.Text = "NOMBRE:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 29);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 2;
            label7.Text = "DNI:";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(286, 25);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(276, 23);
            textBoxNombre.TabIndex = 1;
            // 
            // textBoxDni
            // 
            textBoxDni.Location = new Point(59, 25);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(125, 23);
            textBoxDni.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listAdicionales);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(328, 473);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 209);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "DETALLE ADICIONALES:";
            // 
            // listAdicionales
            // 
            listAdicionales.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnMonto, columnBlanco, columnPorcentual });
            listAdicionales.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listAdicionales.Location = new Point(15, 37);
            listAdicionales.Name = "listAdicionales";
            listAdicionales.Size = new Size(541, 151);
            listAdicionales.TabIndex = 1;
            listAdicionales.UseCompatibleStateImageBehavior = false;
            listAdicionales.View = View.Details;
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
            columnBlanco.Text = "ES OFICIAL?";
            columnBlanco.Width = 80;
            // 
            // columnPorcentual
            // 
            columnPorcentual.Text = "PORCENTUAL";
            columnPorcentual.Width = 90;
            // 
            // listaEmpleados
            // 
            listaEmpleados.Location = new Point(3, 12);
            listaEmpleados.Name = "listaEmpleados";
            listaEmpleados.ServiceProvider = null;
            listaEmpleados.Size = new Size(304, 690);
            listaEmpleados.TabIndex = 5;
            // 
            // VerAcuerdosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 703);
            Controls.Add(listaEmpleados);
            Controls.Add(groupBox1);
            Controls.Add(groupBoxEmpleado);
            Controls.Add(groupBoxHistorial);
            Controls.Add(groupBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerAcuerdosForm";
            Text = "VerContratosForm";
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBoxHistorial.ResumeLayout(false);
            groupBoxEmpleado.ResumeLayout(false);
            groupBoxEmpleado.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

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
        private TextBox textBoxTipoSueldo;
        private TextBox textBoxCodAcuerdo;
        private TextBox textBoxFechaAcuerdo;
        private TextBox textBoxValorBlanco;
        private TextBox textBoxValorSueldo;
        private TextBox textBoxValorHora;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBoxEmpleado;
        private Label label8;
        private Label label7;
        private TextBox textBoxNombre;
        private TextBox textBoxDni;
        private GroupBox groupBox1;
        private ListView listAdicionales;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnMonto;
        private ColumnHeader columnBlanco;
        private ColumnHeader columnPorcentual;
        private Components.Utils.ListaEmpComponent listaEmpleados;
    }
}