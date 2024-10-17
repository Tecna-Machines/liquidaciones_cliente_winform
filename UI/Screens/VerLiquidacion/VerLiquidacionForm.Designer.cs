namespace UI.Screens.VerLiquidacion
{
    partial class VerLiquidacionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerLiquidacionForm));
            labelDetalleLiq = new Label();
            textBoxCodigoLiq = new TextBox();
            labelCod = new Label();
            label1 = new Label();
            textBoxPeriodo = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBoxFechaInicio = new TextBox();
            textBoxFechaFin = new TextBox();
            label4 = new Label();
            textBoxDni = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            textBoxFechaIng = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            listaSueldoBlanco = new ListView();
            columnDescripcion = new ColumnHeader();
            columnFecha = new ColumnHeader();
            columnRemunerativo = new ColumnHeader();
            columnNORemu = new ColumnHeader();
            columnDesc = new ColumnHeader();
            label11 = new Label();
            listaSueldoBillete = new ListView();
            columDescrip = new ColumnHeader();
            columFecha = new ColumnHeader();
            columMonto = new ColumnHeader();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            textBoxCodigoContrato = new TextBox();
            label15 = new Label();
            textBoxFechaContrato = new TextBox();
            label16 = new Label();
            textBoxMontoHoraContrato = new TextBox();
            label17 = new Label();
            textBoxMontoFijoContrato = new TextBox();
            label18 = new Label();
            textBoxModalidad = new TextBox();
            label19 = new Label();
            textBoxParteBlancaContrato = new TextBox();
            listaPagos = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            button1 = new Button();
            textBoxFechaCreacion = new TextBox();
            label20 = new Label();
            progressBar = new ProgressBar();
            btnPagos = new Button();
            SuspendLayout();
            // 
            // labelDetalleLiq
            // 
            labelDetalleLiq.BackColor = SystemColors.ActiveCaption;
            labelDetalleLiq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelDetalleLiq.Location = new Point(12, 18);
            labelDetalleLiq.Name = "labelDetalleLiq";
            labelDetalleLiq.Size = new Size(553, 23);
            labelDetalleLiq.TabIndex = 0;
            labelDetalleLiq.Text = "Detalle Liquidacion";
            // 
            // textBoxCodigoLiq
            // 
            textBoxCodigoLiq.BackColor = SystemColors.HighlightText;
            textBoxCodigoLiq.Location = new Point(85, 53);
            textBoxCodigoLiq.Name = "textBoxCodigoLiq";
            textBoxCodigoLiq.ReadOnly = true;
            textBoxCodigoLiq.Size = new Size(158, 23);
            textBoxCodigoLiq.TabIndex = 1;
            // 
            // labelCod
            // 
            labelCod.AutoSize = true;
            labelCod.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            labelCod.Location = new Point(12, 54);
            labelCod.Name = "labelCod";
            labelCod.Size = new Size(67, 19);
            labelCod.TabIndex = 2;
            labelCod.Text = "CODIGO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 83);
            label1.Name = "label1";
            label1.Size = new Size(71, 19);
            label1.TabIndex = 4;
            label1.Text = "PERIODO:";
            // 
            // textBoxPeriodo
            // 
            textBoxPeriodo.BackColor = SystemColors.HighlightText;
            textBoxPeriodo.Location = new Point(85, 82);
            textBoxPeriodo.Name = "textBoxPeriodo";
            textBoxPeriodo.ReadOnly = true;
            textBoxPeriodo.Size = new Size(158, 23);
            textBoxPeriodo.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(284, 56);
            label2.Name = "label2";
            label2.Size = new Size(117, 19);
            label2.TabIndex = 5;
            label2.Text = "INICIO PERIODO:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(285, 83);
            label3.Name = "label3";
            label3.Size = new Size(96, 19);
            label3.TabIndex = 6;
            label3.Text = "FIN PERIODO:";
            // 
            // textBoxFechaInicio
            // 
            textBoxFechaInicio.BackColor = SystemColors.HighlightText;
            textBoxFechaInicio.Location = new Point(407, 52);
            textBoxFechaInicio.Name = "textBoxFechaInicio";
            textBoxFechaInicio.ReadOnly = true;
            textBoxFechaInicio.Size = new Size(158, 23);
            textBoxFechaInicio.TabIndex = 7;
            // 
            // textBoxFechaFin
            // 
            textBoxFechaFin.BackColor = SystemColors.HighlightText;
            textBoxFechaFin.Location = new Point(407, 82);
            textBoxFechaFin.Name = "textBoxFechaFin";
            textBoxFechaFin.ReadOnly = true;
            textBoxFechaFin.Size = new Size(158, 23);
            textBoxFechaFin.TabIndex = 8;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 121);
            label4.Name = "label4";
            label4.Size = new Size(553, 23);
            label4.TabIndex = 9;
            label4.Text = "Detalle Empleado";
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.HighlightText;
            textBoxDni.Location = new Point(91, 162);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(158, 23);
            textBoxDni.TabIndex = 10;
            // 
            // textBoxNombre
            // 
            textBoxNombre.BackColor = SystemColors.HighlightText;
            textBoxNombre.Location = new Point(91, 199);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(158, 23);
            textBoxNombre.TabIndex = 11;
            // 
            // textBoxApellido
            // 
            textBoxApellido.BackColor = SystemColors.HighlightText;
            textBoxApellido.Location = new Point(91, 237);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.ReadOnly = true;
            textBoxApellido.Size = new Size(158, 23);
            textBoxApellido.TabIndex = 12;
            // 
            // textBoxFechaIng
            // 
            textBoxFechaIng.BackColor = SystemColors.HighlightText;
            textBoxFechaIng.Location = new Point(393, 167);
            textBoxFechaIng.Name = "textBoxFechaIng";
            textBoxFechaIng.ReadOnly = true;
            textBoxFechaIng.Size = new Size(158, 23);
            textBoxFechaIng.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(43, 166);
            label5.Name = "label5";
            label5.Size = new Size(36, 19);
            label5.TabIndex = 14;
            label5.Text = "DNI:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 199);
            label6.Name = "label6";
            label6.Size = new Size(73, 19);
            label6.TabIndex = 15;
            label6.Text = "Nombre/s:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 238);
            label7.Name = "label7";
            label7.Size = new Size(72, 19);
            label7.TabIndex = 16;
            label7.Text = "Apellido/s:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(272, 166);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 17;
            label8.Text = "Fecha de ingreso:";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(21, 278);
            label9.Name = "label9";
            label9.Size = new Size(1150, 23);
            label9.TabIndex = 18;
            label9.Text = "Detalle de sueldo";
            // 
            // label10
            // 
            label10.BackColor = Color.PaleGreen;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(21, 315);
            label10.Name = "label10";
            label10.Size = new Size(572, 23);
            label10.TabIndex = 19;
            label10.Text = "Detalle de sueldo (en blanco)";
            // 
            // listaSueldoBlanco
            // 
            listaSueldoBlanco.Columns.AddRange(new ColumnHeader[] { columnDescripcion, columnFecha, columnRemunerativo, columnNORemu, columnDesc });
            listaSueldoBlanco.FullRowSelect = true;
            listaSueldoBlanco.GridLines = true;
            listaSueldoBlanco.Location = new Point(21, 341);
            listaSueldoBlanco.Name = "listaSueldoBlanco";
            listaSueldoBlanco.Size = new Size(572, 219);
            listaSueldoBlanco.TabIndex = 20;
            listaSueldoBlanco.UseCompatibleStateImageBehavior = false;
            listaSueldoBlanco.View = View.Details;
            // 
            // columnDescripcion
            // 
            columnDescripcion.Text = "Descripcion";
            columnDescripcion.Width = 180;
            // 
            // columnFecha
            // 
            columnFecha.Text = "Fecha";
            // 
            // columnRemunerativo
            // 
            columnRemunerativo.Text = "Remunerativo";
            columnRemunerativo.Width = 95;
            // 
            // columnNORemu
            // 
            columnNORemu.Text = "No Remunerativo";
            columnNORemu.Width = 120;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descuento";
            columnDesc.Width = 90;
            // 
            // label11
            // 
            label11.BackColor = Color.OrangeRed;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(599, 315);
            label11.Name = "label11";
            label11.Size = new Size(572, 23);
            label11.TabIndex = 21;
            label11.Text = "Detalle de sueldo (billete)";
            // 
            // listaSueldoBillete
            // 
            listaSueldoBillete.Columns.AddRange(new ColumnHeader[] { columDescrip, columFecha, columMonto });
            listaSueldoBillete.FullRowSelect = true;
            listaSueldoBillete.GridLines = true;
            listaSueldoBillete.Location = new Point(599, 341);
            listaSueldoBillete.Name = "listaSueldoBillete";
            listaSueldoBillete.Size = new Size(572, 219);
            listaSueldoBillete.TabIndex = 22;
            listaSueldoBillete.UseCompatibleStateImageBehavior = false;
            listaSueldoBillete.View = View.Details;
            // 
            // columDescrip
            // 
            columDescrip.Text = "Descripcion";
            columDescrip.Width = 350;
            // 
            // columFecha
            // 
            columFecha.Text = "Fecha";
            columFecha.Width = 90;
            // 
            // columMonto
            // 
            columMonto.Text = "Monto";
            columMonto.Width = 87;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(21, 579);
            label12.Name = "label12";
            label12.Size = new Size(572, 23);
            label12.TabIndex = 23;
            label12.Text = "Detalle de pagos";
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(583, 121);
            label13.Name = "label13";
            label13.Size = new Size(588, 23);
            label13.TabIndex = 24;
            label13.Text = "Detalle del acuerdo";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(705, 199);
            label14.Name = "label14";
            label14.Size = new Size(67, 19);
            label14.TabIndex = 26;
            label14.Text = "CODIGO:";
            // 
            // textBoxCodigoContrato
            // 
            textBoxCodigoContrato.BackColor = SystemColors.HighlightText;
            textBoxCodigoContrato.Location = new Point(778, 200);
            textBoxCodigoContrato.Name = "textBoxCodigoContrato";
            textBoxCodigoContrato.ReadOnly = true;
            textBoxCodigoContrato.Size = new Size(103, 23);
            textBoxCodigoContrato.TabIndex = 25;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(705, 234);
            label15.Name = "label15";
            label15.Size = new Size(54, 19);
            label15.TabIndex = 28;
            label15.Text = "FECHA:";
            // 
            // textBoxFechaContrato
            // 
            textBoxFechaContrato.BackColor = SystemColors.HighlightText;
            textBoxFechaContrato.Location = new Point(778, 233);
            textBoxFechaContrato.Name = "textBoxFechaContrato";
            textBoxFechaContrato.ReadOnly = true;
            textBoxFechaContrato.Size = new Size(103, 23);
            textBoxFechaContrato.TabIndex = 27;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(890, 233);
            label16.Name = "label16";
            label16.Size = new Size(105, 19);
            label16.TabIndex = 32;
            label16.Text = "MONTO HORA:";
            // 
            // textBoxMontoHoraContrato
            // 
            textBoxMontoHoraContrato.BackColor = SystemColors.HighlightText;
            textBoxMontoHoraContrato.Location = new Point(1001, 232);
            textBoxMontoHoraContrato.Name = "textBoxMontoHoraContrato";
            textBoxMontoHoraContrato.ReadOnly = true;
            textBoxMontoHoraContrato.Size = new Size(170, 23);
            textBoxMontoHoraContrato.TabIndex = 31;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(890, 200);
            label17.Name = "label17";
            label17.Size = new Size(94, 19);
            label17.TabIndex = 30;
            label17.Text = "MONTO FIJO:";
            // 
            // textBoxMontoFijoContrato
            // 
            textBoxMontoFijoContrato.BackColor = SystemColors.HighlightText;
            textBoxMontoFijoContrato.Location = new Point(1001, 198);
            textBoxMontoFijoContrato.Name = "textBoxMontoFijoContrato";
            textBoxMontoFijoContrato.ReadOnly = true;
            textBoxMontoFijoContrato.Size = new Size(170, 23);
            textBoxMontoFijoContrato.TabIndex = 29;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(583, 166);
            label18.Name = "label18";
            label18.Size = new Size(95, 19);
            label18.TabIndex = 33;
            label18.Text = "MODALIDAD:";
            // 
            // textBoxModalidad
            // 
            textBoxModalidad.BackColor = SystemColors.HighlightText;
            textBoxModalidad.Location = new Point(684, 162);
            textBoxModalidad.Name = "textBoxModalidad";
            textBoxModalidad.ReadOnly = true;
            textBoxModalidad.Size = new Size(487, 23);
            textBoxModalidad.TabIndex = 34;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(583, 199);
            label19.Name = "label19";
            label19.Size = new Size(105, 19);
            label19.TabIndex = 35;
            label19.Text = "PARTE BLANCA:";
            // 
            // textBoxParteBlancaContrato
            // 
            textBoxParteBlancaContrato.BackColor = SystemColors.HighlightText;
            textBoxParteBlancaContrato.Location = new Point(583, 229);
            textBoxParteBlancaContrato.Name = "textBoxParteBlancaContrato";
            textBoxParteBlancaContrato.ReadOnly = true;
            textBoxParteBlancaContrato.Size = new Size(103, 23);
            textBoxParteBlancaContrato.TabIndex = 36;
            // 
            // listaPagos
            // 
            listaPagos.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listaPagos.FullRowSelect = true;
            listaPagos.GridLines = true;
            listaPagos.Location = new Point(21, 605);
            listaPagos.Name = "listaPagos";
            listaPagos.Size = new Size(572, 68);
            listaPagos.TabIndex = 37;
            listaPagos.UseCompatibleStateImageBehavior = false;
            listaPagos.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Codigo";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Fecha";
            columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Monto";
            columnHeader3.Width = 95;
            // 
            // button1
            // 
            button1.BackColor = Color.SpringGreen;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(619, 619);
            button1.Name = "button1";
            button1.Size = new Size(122, 54);
            button1.TabIndex = 38;
            button1.Text = "GENERAR RECIBO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += ClickBtnGenerarRecibo;
            // 
            // textBoxFechaCreacion
            // 
            textBoxFechaCreacion.BackColor = SystemColors.HighlightText;
            textBoxFechaCreacion.Location = new Point(393, 200);
            textBoxFechaCreacion.Name = "textBoxFechaCreacion";
            textBoxFechaCreacion.ReadOnly = true;
            textBoxFechaCreacion.Size = new Size(158, 23);
            textBoxFechaCreacion.TabIndex = 39;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(272, 202);
            label20.Name = "label20";
            label20.Size = new Size(120, 19);
            label20.TabIndex = 40;
            label20.Text = "Fecha de creacion:";
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.AppWorkspace;
            progressBar.Location = new Point(340, 278);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(493, 51);
            progressBar.TabIndex = 41;
            progressBar.Visible = false;
            // 
            // btnPagos
            // 
            btnPagos.BackColor = SystemColors.ActiveCaption;
            btnPagos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagos.Location = new Point(758, 619);
            btnPagos.Name = "btnPagos";
            btnPagos.Size = new Size(123, 54);
            btnPagos.TabIndex = 42;
            btnPagos.Text = "AGREGAR PAGO";
            btnPagos.UseVisualStyleBackColor = false;
            btnPagos.Click += btnPagos_Click;
            // 
            // VerLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1205, 694);
            Controls.Add(btnPagos);
            Controls.Add(progressBar);
            Controls.Add(label20);
            Controls.Add(textBoxFechaCreacion);
            Controls.Add(button1);
            Controls.Add(listaPagos);
            Controls.Add(textBoxParteBlancaContrato);
            Controls.Add(label19);
            Controls.Add(textBoxModalidad);
            Controls.Add(label18);
            Controls.Add(label16);
            Controls.Add(textBoxMontoHoraContrato);
            Controls.Add(label17);
            Controls.Add(textBoxMontoFijoContrato);
            Controls.Add(label15);
            Controls.Add(textBoxFechaContrato);
            Controls.Add(label14);
            Controls.Add(textBoxCodigoContrato);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(listaSueldoBillete);
            Controls.Add(label11);
            Controls.Add(listaSueldoBlanco);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBoxFechaIng);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            Controls.Add(textBoxDni);
            Controls.Add(label4);
            Controls.Add(textBoxFechaFin);
            Controls.Add(textBoxFechaInicio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxPeriodo);
            Controls.Add(labelCod);
            Controls.Add(textBoxCodigoLiq);
            Controls.Add(labelDetalleLiq);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VerLiquidacionForm";
            Text = "VerLiquidacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDetalleLiq;
        private TextBox textBoxCodigoLiq;
        private Label labelCod;
        private Label label1;
        private TextBox textBoxPeriodo;
        private Label label2;
        private Label label3;
        private TextBox textBoxFechaInicio;
        private TextBox textBoxFechaFin;
        private Label label4;
        private TextBox textBoxDni;
        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private TextBox textBoxFechaIng;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListView listaSueldoBlanco;
        private ColumnHeader columnDescripcion;
        private ColumnHeader columnFecha;
        private ColumnHeader columnRemunerativo;
        private ColumnHeader columnNORemu;
        private ColumnHeader columnDesc;
        private Label label11;
        private ListView listaSueldoBillete;
        private ColumnHeader columDescrip;
        private ColumnHeader columFecha;
        private ColumnHeader columMonto;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textBoxCodigoContrato;
        private Label label15;
        private TextBox textBoxFechaContrato;
        private Label label16;
        private TextBox textBoxMontoHoraContrato;
        private Label label17;
        private TextBox textBoxMontoFijoContrato;
        private Label label18;
        private TextBox textBoxModalidad;
        private Label label19;
        private TextBox textBoxParteBlancaContrato;
        private ListView listaPagos;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button button1;
        private TextBox textBoxFechaCreacion;
        private Label label20;
        private ProgressBar progressBar;
        private Button btnPagos;
    }
}