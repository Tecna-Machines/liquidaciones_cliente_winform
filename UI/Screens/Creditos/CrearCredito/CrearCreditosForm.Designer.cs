namespace UI.Screens.VerCreditos
{
    partial class CrearCreditosForm
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
            listaEmpleados = new UI.Components.Utils.ListaEmpComponent();
            panelDatos = new Panel();
            label4 = new Label();
            textBoxNombreCompleto = new TextBox();
            label3 = new Label();
            textBoxDni = new TextBox();
            label1 = new Label();
            TextDescripcion = new RichTextBox();
            label2 = new Label();
            comboBoxCantCuotas = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            TextMontoPrestado = new RichTextBox();
            TextMontoDevolver = new RichTextBox();
            label7 = new Label();
            TextValorCuota = new RichTextBox();
            label8 = new Label();
            label9 = new Label();
            ComboQuincena = new ComboBox();
            ComboMes = new ComboBox();
            ComboAnio = new ComboBox();
            BtnConfirmarCredito = new Button();
            groupBoxModoPago = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            panelDatos.SuspendLayout();
            groupBoxModoPago.SuspendLayout();
            SuspendLayout();
            // 
            // listaEmpleados
            // 
            listaEmpleados.Location = new Point(3, 12);
            listaEmpleados.Name = "listaEmpleados";
            listaEmpleados.ServiceProvider = null;
            listaEmpleados.Size = new Size(304, 690);
            listaEmpleados.TabIndex = 23;
            // 
            // panelDatos
            // 
            panelDatos.Controls.Add(label4);
            panelDatos.Controls.Add(textBoxNombreCompleto);
            panelDatos.Controls.Add(label3);
            panelDatos.Controls.Add(textBoxDni);
            panelDatos.Location = new Point(299, 42);
            panelDatos.Name = "panelDatos";
            panelDatos.Size = new Size(814, 109);
            panelDatos.TabIndex = 24;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(224, 35);
            label4.Name = "label4";
            label4.Padding = new Padding(3);
            label4.Size = new Size(579, 24);
            label4.TabIndex = 22;
            label4.Text = "NOMBRE COMPLETO";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxNombreCompleto
            // 
            textBoxNombreCompleto.BackColor = SystemColors.ButtonHighlight;
            textBoxNombreCompleto.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxNombreCompleto.Location = new Point(224, 62);
            textBoxNombreCompleto.Name = "textBoxNombreCompleto";
            textBoxNombreCompleto.ReadOnly = true;
            textBoxNombreCompleto.Size = new Size(579, 29);
            textBoxNombreCompleto.TabIndex = 21;
            textBoxNombreCompleto.Text = "PLACEHOLDER DE NOMBRE LARGO";
            textBoxNombreCompleto.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(18, 35);
            label3.Name = "label3";
            label3.Padding = new Padding(3);
            label3.Size = new Size(181, 24);
            label3.TabIndex = 20;
            label3.Text = "DNI";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDni.Location = new Point(18, 62);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(181, 29);
            textBoxDni.TabIndex = 0;
            textBoxDni.Text = "90000000";
            textBoxDni.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(317, 170);
            label1.Name = "label1";
            label1.Padding = new Padding(3);
            label1.Size = new Size(181, 33);
            label1.TabIndex = 23;
            label1.Text = "Descripcion:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // TextDescripcion
            // 
            TextDescripcion.Location = new Point(504, 170);
            TextDescripcion.Name = "TextDescripcion";
            TextDescripcion.Size = new Size(524, 33);
            TextDescripcion.TabIndex = 25;
            TextDescripcion.Text = "";
            // 
            // label2
            // 
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(317, 326);
            label2.Name = "label2";
            label2.Padding = new Padding(3);
            label2.Size = new Size(181, 33);
            label2.TabIndex = 26;
            label2.Text = "Cant. cuotas:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // comboBoxCantCuotas
            // 
            comboBoxCantCuotas.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxCantCuotas.FormattingEnabled = true;
            comboBoxCantCuotas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25" });
            comboBoxCantCuotas.Location = new Point(504, 328);
            comboBoxCantCuotas.Name = "comboBoxCantCuotas";
            comboBoxCantCuotas.Size = new Size(121, 29);
            comboBoxCantCuotas.TabIndex = 27;
            comboBoxCantCuotas.SelectedValueChanged += ComboBoxCantCuotas_SelectedValueChanged;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaption;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(317, 222);
            label5.Name = "label5";
            label5.Padding = new Padding(3);
            label5.Size = new Size(181, 33);
            label5.TabIndex = 28;
            label5.Text = "Monto prestado:";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaption;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(317, 274);
            label6.Name = "label6";
            label6.Padding = new Padding(3);
            label6.Size = new Size(181, 33);
            label6.TabIndex = 29;
            label6.Text = "Monto a devolver:";
            label6.TextAlign = ContentAlignment.TopRight;
            // 
            // TextMontoPrestado
            // 
            TextMontoPrestado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextMontoPrestado.Location = new Point(504, 222);
            TextMontoPrestado.Name = "TextMontoPrestado";
            TextMontoPrestado.Size = new Size(272, 33);
            TextMontoPrestado.TabIndex = 30;
            TextMontoPrestado.Text = "";
            // 
            // TextMontoDevolver
            // 
            TextMontoDevolver.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextMontoDevolver.Location = new Point(504, 274);
            TextMontoDevolver.Name = "TextMontoDevolver";
            TextMontoDevolver.Size = new Size(272, 33);
            TextMontoDevolver.TabIndex = 31;
            TextMontoDevolver.Text = "";
            TextMontoDevolver.TextChanged += TextMontoDevolver_TextChanged;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaption;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(317, 378);
            label7.Name = "label7";
            label7.Padding = new Padding(3);
            label7.Size = new Size(181, 33);
            label7.TabIndex = 32;
            label7.Text = "Valor cuota:";
            label7.TextAlign = ContentAlignment.TopRight;
            // 
            // TextValorCuota
            // 
            TextValorCuota.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextValorCuota.Location = new Point(504, 378);
            TextValorCuota.Name = "TextValorCuota";
            TextValorCuota.ReadOnly = true;
            TextValorCuota.Size = new Size(121, 33);
            TextValorCuota.TabIndex = 33;
            TextValorCuota.Text = "";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaption;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(317, 482);
            label8.Name = "label8";
            label8.Padding = new Padding(3);
            label8.Size = new Size(181, 33);
            label8.TabIndex = 34;
            label8.Text = "Modo de pago:";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaption;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(317, 430);
            label9.Name = "label9";
            label9.Padding = new Padding(3);
            label9.Size = new Size(181, 33);
            label9.TabIndex = 38;
            label9.Text = "Quincena de gracia:";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // ComboQuincena
            // 
            ComboQuincena.FormattingEnabled = true;
            ComboQuincena.Items.AddRange(new object[] { "1", "2" });
            ComboQuincena.Location = new Point(504, 435);
            ComboQuincena.Name = "ComboQuincena";
            ComboQuincena.Size = new Size(51, 23);
            ComboQuincena.TabIndex = 39;
            // 
            // ComboMes
            // 
            ComboMes.FormattingEnabled = true;
            ComboMes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            ComboMes.Location = new Point(568, 435);
            ComboMes.Name = "ComboMes";
            ComboMes.Size = new Size(51, 23);
            ComboMes.TabIndex = 40;
            // 
            // ComboAnio
            // 
            ComboAnio.FormattingEnabled = true;
            ComboAnio.Items.AddRange(new object[] { "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036" });
            ComboAnio.Location = new Point(632, 435);
            ComboAnio.Name = "ComboAnio";
            ComboAnio.Size = new Size(76, 23);
            ComboAnio.TabIndex = 41;
            // 
            // BtnConfirmarCredito
            // 
            BtnConfirmarCredito.BackColor = Color.Gold;
            BtnConfirmarCredito.BackgroundImageLayout = ImageLayout.None;
            BtnConfirmarCredito.Cursor = Cursors.Hand;
            BtnConfirmarCredito.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmarCredito.Location = new Point(317, 647);
            BtnConfirmarCredito.Name = "BtnConfirmarCredito";
            BtnConfirmarCredito.Size = new Size(168, 41);
            BtnConfirmarCredito.TabIndex = 42;
            BtnConfirmarCredito.Text = "CONFIRMAR";
            BtnConfirmarCredito.UseVisualStyleBackColor = false;
            // 
            // groupBoxModoPago
            // 
            groupBoxModoPago.Controls.Add(radioButton3);
            groupBoxModoPago.Controls.Add(radioButton2);
            groupBoxModoPago.Controls.Add(radioButton1);
            groupBoxModoPago.Location = new Point(317, 528);
            groupBoxModoPago.Name = "groupBoxModoPago";
            groupBoxModoPago.Size = new Size(534, 113);
            groupBoxModoPago.TabIndex = 43;
            groupBoxModoPago.TabStop = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton3.Location = new Point(11, 90);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(512, 17);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "SEGUNDA QUINCENA  (el valor de la cuota se descontara solo la segunda quincena)";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton2.Location = new Point(11, 58);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(490, 17);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "PRIMER  QUINCENA  (el valor de la cuota se descontara solo la primer quincena)";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            radioButton1.Location = new Point(11, 26);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(446, 17);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "POR QUINCENA  (el valor de la cuota se descontara todas las quincenas)";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // CrearCreditosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 700);
            Controls.Add(groupBoxModoPago);
            Controls.Add(BtnConfirmarCredito);
            Controls.Add(ComboAnio);
            Controls.Add(ComboMes);
            Controls.Add(ComboQuincena);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(TextValorCuota);
            Controls.Add(label7);
            Controls.Add(TextMontoDevolver);
            Controls.Add(TextMontoPrestado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(comboBoxCantCuotas);
            Controls.Add(label2);
            Controls.Add(TextDescripcion);
            Controls.Add(label1);
            Controls.Add(panelDatos);
            Controls.Add(listaEmpleados);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CrearCreditosForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VerCreditosForm";
            panelDatos.ResumeLayout(false);
            panelDatos.PerformLayout();
            groupBoxModoPago.ResumeLayout(false);
            groupBoxModoPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Components.Utils.ListaEmpComponent listaEmpleados;
        private Panel panelDatos;
        private Label label4;
        private TextBox textBoxNombreCompleto;
        private Label label3;
        private TextBox textBoxDni;
        private Label label1;
        private RichTextBox TextDescripcion;
        private Label label2;
        private ComboBox comboBoxCantCuotas;
        private Label label5;
        private Label label6;
        private RichTextBox TextMontoPrestado;
        private RichTextBox TextMontoDevolver;
        private Label label7;
        private RichTextBox TextValorCuota;
        private Label label8;
        private Label label9;
        private ComboBox ComboQuincena;
        private ComboBox ComboMes;
        private ComboBox ComboAnio;
        private Button BtnConfirmarCredito;
        private GroupBox groupBoxModoPago;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}