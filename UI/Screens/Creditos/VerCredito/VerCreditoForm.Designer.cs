namespace UI.Screens.Creditos.VerCredito
{
    partial class VerCreditoForm
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
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            TextDescripcion = new RichTextBox();
            textMontoPrestado = new RichTextBox();
            textMontoDevoler = new RichTextBox();
            textModoPago = new RichTextBox();
            labelRemuneraciones = new Label();
            label4 = new Label();
            textNombreCompleto = new TextBox();
            label3 = new Label();
            textDni = new TextBox();
            label2 = new Label();
            textCodigo = new TextBox();
            BtnPosponerCuota = new Button();
            columnNro = new ColumnHeader();
            columnDesc = new ColumnHeader();
            columnMonto = new ColumnHeader();
            columnSeDebita = new ColumnHeader();
            columnEstado = new ColumnHeader();
            tablaCuotas = new ListView();
            label7 = new Label();
            label9 = new Label();
            textCuotaMonto = new TextBox();
            textCuotaPagada = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textCuotaQuincena = new TextBox();
            textCuotaDescripcion = new TextBox();
            BtnVerLiquidacion = new Button();
            textCuotaNro = new TextBox();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(12, 197);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(150, 33);
            label8.TabIndex = 44;
            label8.Text = "Modo de pago:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(472, 197);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(150, 33);
            label6.TabIndex = 42;
            label6.Text = "Monto a devolver:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(472, 140);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(150, 33);
            label5.TabIndex = 41;
            label5.Text = "Monto prestado:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(150, 33);
            label1.TabIndex = 39;
            label1.Text = "Descripcion:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // TextDescripcion
            // 
            TextDescripcion.BackColor = SystemColors.GrayText;
            TextDescripcion.BorderStyle = BorderStyle.FixedSingle;
            TextDescripcion.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TextDescripcion.ForeColor = Color.WhiteSmoke;
            TextDescripcion.Location = new Point(168, 140);
            TextDescripcion.Name = "TextDescripcion";
            TextDescripcion.ReadOnly = true;
            TextDescripcion.Size = new Size(298, 33);
            TextDescripcion.TabIndex = 46;
            TextDescripcion.Text = "";
            // 
            // textMontoPrestado
            // 
            textMontoPrestado.BackColor = SystemColors.GrayText;
            textMontoPrestado.BorderStyle = BorderStyle.FixedSingle;
            textMontoPrestado.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textMontoPrestado.ForeColor = Color.WhiteSmoke;
            textMontoPrestado.Location = new Point(628, 140);
            textMontoPrestado.Name = "textMontoPrestado";
            textMontoPrestado.ReadOnly = true;
            textMontoPrestado.Size = new Size(185, 33);
            textMontoPrestado.TabIndex = 47;
            textMontoPrestado.Text = "";
            // 
            // textMontoDevoler
            // 
            textMontoDevoler.BackColor = SystemColors.GrayText;
            textMontoDevoler.BorderStyle = BorderStyle.FixedSingle;
            textMontoDevoler.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textMontoDevoler.ForeColor = Color.WhiteSmoke;
            textMontoDevoler.Location = new Point(628, 197);
            textMontoDevoler.Name = "textMontoDevoler";
            textMontoDevoler.ReadOnly = true;
            textMontoDevoler.Size = new Size(185, 33);
            textMontoDevoler.TabIndex = 48;
            textMontoDevoler.Text = "";
            // 
            // textModoPago
            // 
            textModoPago.BackColor = SystemColors.GrayText;
            textModoPago.BorderStyle = BorderStyle.FixedSingle;
            textModoPago.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textModoPago.ForeColor = Color.WhiteSmoke;
            textModoPago.Location = new Point(168, 197);
            textModoPago.Name = "textModoPago";
            textModoPago.ReadOnly = true;
            textModoPago.Size = new Size(298, 33);
            textModoPago.TabIndex = 52;
            textModoPago.Text = "";
            // 
            // labelRemuneraciones
            // 
            labelRemuneraciones.BackColor = SystemColors.ActiveCaption;
            labelRemuneraciones.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelRemuneraciones.Location = new Point(12, 261);
            labelRemuneraciones.Name = "labelRemuneraciones";
            labelRemuneraciones.Padding = new Padding(3);
            labelRemuneraciones.Size = new Size(801, 24);
            labelRemuneraciones.TabIndex = 53;
            labelRemuneraciones.Text = "Cuotas";
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(218, 59);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(595, 24);
            label4.TabIndex = 58;
            label4.Text = "EMPLEADO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textNombreCompleto
            // 
            textNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            textNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textNombreCompleto.Location = new Point(218, 86);
            textNombreCompleto.Name = "textNombreCompleto";
            textNombreCompleto.ReadOnly = true;
            textNombreCompleto.Size = new Size(595, 29);
            textNombreCompleto.TabIndex = 57;
            textNombreCompleto.Text = "00000000 - Mariano Mirian Leguizamol";
            textNombreCompleto.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 59);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(181, 24);
            label3.TabIndex = 56;
            label3.Text = "DNI:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textDni
            // 
            textDni.BackColor = SystemColors.ButtonHighlight;
            textDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textDni.Location = new Point(12, 86);
            textDni.Name = "textDni";
            textDni.ReadOnly = true;
            textDni.Size = new Size(181, 29);
            textDni.TabIndex = 55;
            textDni.Text = "000000000";
            textDni.TextAlign = HorizontalAlignment.Center;
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 18);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(181, 24);
            label2.TabIndex = 59;
            label2.Text = "CODIGO INTERNO:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textCodigo
            // 
            textCodigo.BackColor = SystemColors.ButtonHighlight;
            textCodigo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textCodigo.Location = new Point(218, 17);
            textCodigo.Name = "textCodigo";
            textCodigo.ReadOnly = true;
            textCodigo.Size = new Size(595, 29);
            textCodigo.TabIndex = 60;
            textCodigo.Text = "000000000";
            textCodigo.TextAlign = HorizontalAlignment.Center;
            // 
            // BtnPosponerCuota
            // 
            BtnPosponerCuota.BackColor = Color.Tomato;
            BtnPosponerCuota.Cursor = Cursors.Hand;
            BtnPosponerCuota.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnPosponerCuota.Location = new Point(819, 466);
            BtnPosponerCuota.Name = "BtnPosponerCuota";
            BtnPosponerCuota.Size = new Size(172, 41);
            BtnPosponerCuota.TabIndex = 61;
            BtnPosponerCuota.Text = "POSPONER CUOTA";
            BtnPosponerCuota.UseVisualStyleBackColor = false;
            BtnPosponerCuota.Click += BtnPosponerCuota_Click;
            // 
            // columnNro
            // 
            columnNro.Text = "Nro";
            columnNro.Width = 40;
            // 
            // columnDesc
            // 
            columnDesc.Text = "Descripcion";
            columnDesc.Width = 220;
            // 
            // columnMonto
            // 
            columnMonto.Text = "Monto";
            columnMonto.Width = 100;
            // 
            // columnSeDebita
            // 
            columnSeDebita.Text = "Se debita:";
            columnSeDebita.Width = 130;
            // 
            // columnEstado
            // 
            columnEstado.Text = "Estado";
            columnEstado.Width = 120;
            // 
            // tablaCuotas
            // 
            tablaCuotas.Columns.AddRange(new ColumnHeader[] { columnNro, columnDesc, columnMonto, columnSeDebita, columnEstado });
            tablaCuotas.FullRowSelect = true;
            tablaCuotas.GridLines = true;
            tablaCuotas.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            tablaCuotas.Location = new Point(12, 288);
            tablaCuotas.Name = "tablaCuotas";
            tablaCuotas.Size = new Size(801, 219);
            tablaCuotas.TabIndex = 54;
            tablaCuotas.UseCompatibleStateImageBehavior = false;
            tablaCuotas.View = View.Details;
            tablaCuotas.SelectedIndexChanged += TablaCuotas_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(819, 261);
            label7.Name = "label7";
            label7.Padding = new Padding(3);
            label7.Size = new Size(486, 24);
            label7.TabIndex = 63;
            label7.Text = "Detalle cuota";
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(819, 298);
            label9.Name = "label9";
            label9.Padding = new Padding(3);
            label9.Size = new Size(135, 23);
            label9.TabIndex = 64;
            label9.Text = "NRO:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // textCuotaMonto
            // 
            textCuotaMonto.BackColor = SystemColors.Info;
            textCuotaMonto.BorderStyle = BorderStyle.FixedSingle;
            textCuotaMonto.Location = new Point(960, 391);
            textCuotaMonto.Name = "textCuotaMonto";
            textCuotaMonto.ReadOnly = true;
            textCuotaMonto.Size = new Size(345, 23);
            textCuotaMonto.TabIndex = 65;
            // 
            // textCuotaPagada
            // 
            textCuotaPagada.BackColor = SystemColors.Info;
            textCuotaPagada.BorderStyle = BorderStyle.FixedSingle;
            textCuotaPagada.Location = new Point(960, 422);
            textCuotaPagada.Name = "textCuotaPagada";
            textCuotaPagada.ReadOnly = true;
            textCuotaPagada.Size = new Size(345, 23);
            textCuotaPagada.TabIndex = 67;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaption;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(819, 391);
            label10.Name = "label10";
            label10.Padding = new Padding(3);
            label10.Size = new Size(135, 23);
            label10.TabIndex = 66;
            label10.Text = "monto:";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.BackColor = SystemColors.ActiveCaption;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(819, 329);
            label11.Name = "label11";
            label11.Padding = new Padding(3);
            label11.Size = new Size(135, 23);
            label11.TabIndex = 68;
            label11.Text = "descripcion:";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.BackColor = SystemColors.ActiveCaption;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(819, 360);
            label12.Name = "label12";
            label12.Padding = new Padding(3);
            label12.Size = new Size(135, 23);
            label12.TabIndex = 69;
            label12.Text = "quincena de debito:";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label13
            // 
            label13.BackColor = SystemColors.ActiveCaption;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.ForeColor = Color.ForestGreen;
            label13.Location = new Point(819, 422);
            label13.Name = "label13";
            label13.Padding = new Padding(3);
            label13.Size = new Size(135, 23);
            label13.TabIndex = 70;
            label13.Text = "pagada?:";
            label13.TextAlign = ContentAlignment.TopRight;
            // 
            // textCuotaQuincena
            // 
            textCuotaQuincena.BackColor = SystemColors.Info;
            textCuotaQuincena.BorderStyle = BorderStyle.FixedSingle;
            textCuotaQuincena.Location = new Point(960, 360);
            textCuotaQuincena.Name = "textCuotaQuincena";
            textCuotaQuincena.ReadOnly = true;
            textCuotaQuincena.Size = new Size(345, 23);
            textCuotaQuincena.TabIndex = 72;
            // 
            // textCuotaDescripcion
            // 
            textCuotaDescripcion.BackColor = SystemColors.Info;
            textCuotaDescripcion.BorderStyle = BorderStyle.FixedSingle;
            textCuotaDescripcion.Location = new Point(960, 329);
            textCuotaDescripcion.Name = "textCuotaDescripcion";
            textCuotaDescripcion.ReadOnly = true;
            textCuotaDescripcion.Size = new Size(345, 23);
            textCuotaDescripcion.TabIndex = 73;
            // 
            // BtnVerLiquidacion
            // 
            BtnVerLiquidacion.BackColor = Color.LightGreen;
            BtnVerLiquidacion.Cursor = Cursors.Hand;
            BtnVerLiquidacion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            BtnVerLiquidacion.Location = new Point(997, 466);
            BtnVerLiquidacion.Name = "BtnVerLiquidacion";
            BtnVerLiquidacion.Size = new Size(172, 41);
            BtnVerLiquidacion.TabIndex = 75;
            BtnVerLiquidacion.Text = "VER LIQUIDACION";
            BtnVerLiquidacion.UseVisualStyleBackColor = false;
            // 
            // textCuotaNro
            // 
            textCuotaNro.BackColor = SystemColors.Info;
            textCuotaNro.BorderStyle = BorderStyle.FixedSingle;
            textCuotaNro.Location = new Point(960, 298);
            textCuotaNro.Name = "textCuotaNro";
            textCuotaNro.ReadOnly = true;
            textCuotaNro.Size = new Size(345, 23);
            textCuotaNro.TabIndex = 76;
            // 
            // progressBar
            // 
            progressBar.ForeColor = SystemColors.MenuHighlight;
            progressBar.Location = new Point(120, 372);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(587, 42);
            progressBar.TabIndex = 77;
            progressBar.UseWaitCursor = true;
            progressBar.Visible = false;
            // 
            // VerCreditoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1337, 561);
            Controls.Add(progressBar);
            Controls.Add(textCuotaNro);
            Controls.Add(BtnVerLiquidacion);
            Controls.Add(textCuotaDescripcion);
            Controls.Add(textCuotaQuincena);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(textCuotaPagada);
            Controls.Add(label10);
            Controls.Add(textCuotaMonto);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(BtnPosponerCuota);
            Controls.Add(textCodigo);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(textNombreCompleto);
            Controls.Add(label3);
            Controls.Add(textDni);
            Controls.Add(tablaCuotas);
            Controls.Add(labelRemuneraciones);
            Controls.Add(textModoPago);
            Controls.Add(textMontoDevoler);
            Controls.Add(textMontoPrestado);
            Controls.Add(TextDescripcion);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "VerCreditoForm";
            Text = "VerCreditoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label1;
        private RichTextBox TextDescripcion;
        private RichTextBox textMontoPrestado;
        private RichTextBox textMontoDevoler;
        private RichTextBox textModoPago;
        private Label labelRemuneraciones;
        private Label label4;
        private TextBox textNombreCompleto;
        private Label label3;
        private TextBox textDni;
        private Label label2;
        private TextBox textCodigo;
        private Button BtnPosponerCuota;
        private ColumnHeader columnNro;
        private ColumnHeader columnDesc;
        private ColumnHeader columnMonto;
        private ColumnHeader columnSeDebita;
        private ColumnHeader columnEstado;
        private ListView tablaCuotas;
        private Label label7;
        private Label label9;
        private TextBox textCuotaMonto;
        private TextBox textCuotaPagada;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private TextBox textCuotaQuincena;
        private TextBox textBox4;
        private TextBox textCuotaDescripcion;
        private Button BtnVerLiquidacion;
        private TextBox textCuotaNro;
        private ProgressBar progressBar;
    }
}