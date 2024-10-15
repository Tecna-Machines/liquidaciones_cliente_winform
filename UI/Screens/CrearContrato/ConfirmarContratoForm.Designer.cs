namespace UI.Screens.CrearContrato
{
    partial class ConfirmarContratoForm
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
            labelBrutoTotal = new Label();
            TextBoxmontoBrutoTotal = new RichTextBox();
            TextBoxBrutoEfectivo = new RichTextBox();
            labelBrutoEfectivo = new Label();
            TextBoxBrutoBanco = new RichTextBox();
            label1 = new Label();
            TextBoxMontoHora = new RichTextBox();
            label2 = new Label();
            btnConfirmar = new Button();
            labelDni = new Label();
            TextBoxDni = new RichTextBox();
            TextBoxNombres = new RichTextBox();
            labelNombre = new Label();
            TextBoxModalidad = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // labelBrutoTotal
            // 
            labelBrutoTotal.AutoSize = true;
            labelBrutoTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrutoTotal.Location = new Point(259, 55);
            labelBrutoTotal.Name = "labelBrutoTotal";
            labelBrutoTotal.Size = new Size(135, 15);
            labelBrutoTotal.TabIndex = 1;
            labelBrutoTotal.Text = "MONTO BRUTO TOTAL";
            // 
            // TextBoxmontoBrutoTotal
            // 
            TextBoxmontoBrutoTotal.BackColor = SystemColors.ButtonHighlight;
            TextBoxmontoBrutoTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxmontoBrutoTotal.Location = new Point(225, 82);
            TextBoxmontoBrutoTotal.Name = "TextBoxmontoBrutoTotal";
            TextBoxmontoBrutoTotal.ReadOnly = true;
            TextBoxmontoBrutoTotal.RightToLeft = RightToLeft.Yes;
            TextBoxmontoBrutoTotal.Size = new Size(201, 46);
            TextBoxmontoBrutoTotal.TabIndex = 2;
            TextBoxmontoBrutoTotal.Text = "00000000";
            // 
            // TextBoxBrutoEfectivo
            // 
            TextBoxBrutoEfectivo.BackColor = SystemColors.ButtonHighlight;
            TextBoxBrutoEfectivo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxBrutoEfectivo.Location = new Point(225, 178);
            TextBoxBrutoEfectivo.Name = "TextBoxBrutoEfectivo";
            TextBoxBrutoEfectivo.ReadOnly = true;
            TextBoxBrutoEfectivo.RightToLeft = RightToLeft.Yes;
            TextBoxBrutoEfectivo.Size = new Size(201, 46);
            TextBoxBrutoEfectivo.TabIndex = 4;
            TextBoxBrutoEfectivo.Text = "00000000";
            // 
            // labelBrutoEfectivo
            // 
            labelBrutoEfectivo.AutoSize = true;
            labelBrutoEfectivo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrutoEfectivo.Location = new Point(244, 150);
            labelBrutoEfectivo.Name = "labelBrutoEfectivo";
            labelBrutoEfectivo.Size = new Size(160, 15);
            labelBrutoEfectivo.TabIndex = 3;
            labelBrutoEfectivo.Text = "MONTO BRUTO (EFECTIVO)";
            // 
            // TextBoxBrutoBanco
            // 
            TextBoxBrutoBanco.BackColor = SystemColors.ButtonHighlight;
            TextBoxBrutoBanco.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxBrutoBanco.Location = new Point(225, 279);
            TextBoxBrutoBanco.Name = "TextBoxBrutoBanco";
            TextBoxBrutoBanco.ReadOnly = true;
            TextBoxBrutoBanco.RightToLeft = RightToLeft.Yes;
            TextBoxBrutoBanco.Size = new Size(201, 46);
            TextBoxBrutoBanco.TabIndex = 6;
            TextBoxBrutoBanco.Text = "00000000";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(256, 252);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 5;
            label1.Text = "MONTO BRUTO (BANCO)";
            // 
            // TextBoxMontoHora
            // 
            TextBoxMontoHora.BackColor = SystemColors.ButtonHighlight;
            TextBoxMontoHora.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxMontoHora.Location = new Point(225, 376);
            TextBoxMontoHora.Name = "TextBoxMontoHora";
            TextBoxMontoHora.ReadOnly = true;
            TextBoxMontoHora.RightToLeft = RightToLeft.Yes;
            TextBoxMontoHora.Size = new Size(201, 46);
            TextBoxMontoHora.TabIndex = 8;
            TextBoxMontoHora.Text = "00000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(259, 349);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 7;
            label2.Text = "MONTO POR HORA";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Cursor = Cursors.Hand;
            btnConfirmar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(145, 465);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(148, 46);
            btnConfirmar.TabIndex = 9;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(23, 55);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(94, 15);
            labelDni.TabIndex = 10;
            labelDni.Text = "DNI EMPLEADO";
            // 
            // TextBoxDni
            // 
            TextBoxDni.BackColor = SystemColors.ButtonHighlight;
            TextBoxDni.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxDni.Location = new Point(23, 82);
            TextBoxDni.Name = "TextBoxDni";
            TextBoxDni.ReadOnly = true;
            TextBoxDni.RightToLeft = RightToLeft.Yes;
            TextBoxDni.Size = new Size(174, 46);
            TextBoxDni.TabIndex = 11;
            TextBoxDni.Text = "00000000";
            // 
            // TextBoxNombres
            // 
            TextBoxNombres.BackColor = SystemColors.ButtonHighlight;
            TextBoxNombres.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxNombres.Location = new Point(23, 178);
            TextBoxNombres.Name = "TextBoxNombres";
            TextBoxNombres.ReadOnly = true;
            TextBoxNombres.RightToLeft = RightToLeft.Yes;
            TextBoxNombres.Size = new Size(174, 46);
            TextBoxNombres.TabIndex = 13;
            TextBoxNombres.Text = "00000000";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(23, 151);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(130, 15);
            labelNombre.TabIndex = 12;
            labelNombre.Text = "Nombre/s y Apellido/s";
            // 
            // TextBoxModalidad
            // 
            TextBoxModalidad.BackColor = SystemColors.ButtonHighlight;
            TextBoxModalidad.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TextBoxModalidad.Location = new Point(23, 279);
            TextBoxModalidad.Name = "TextBoxModalidad";
            TextBoxModalidad.ReadOnly = true;
            TextBoxModalidad.RightToLeft = RightToLeft.Yes;
            TextBoxModalidad.Size = new Size(174, 46);
            TextBoxModalidad.TabIndex = 15;
            TextBoxModalidad.Text = "QUINCENAL FIJO + HS EXTRAS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(23, 252);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 14;
            label3.Text = "MODALIDAD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(163, 9);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 16;
            label4.Text = "CONTRATO";
            // 
            // ConfirmarContratoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 531);
            Controls.Add(label4);
            Controls.Add(TextBoxModalidad);
            Controls.Add(label3);
            Controls.Add(TextBoxNombres);
            Controls.Add(labelNombre);
            Controls.Add(TextBoxDni);
            Controls.Add(labelDni);
            Controls.Add(btnConfirmar);
            Controls.Add(TextBoxMontoHora);
            Controls.Add(label2);
            Controls.Add(TextBoxBrutoBanco);
            Controls.Add(label1);
            Controls.Add(TextBoxBrutoEfectivo);
            Controls.Add(labelBrutoEfectivo);
            Controls.Add(TextBoxmontoBrutoTotal);
            Controls.Add(labelBrutoTotal);
            MinimizeBox = false;
            Name = "ConfirmarContratoForm";
            Text = "ConfirmarContratoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBrutoTotal;
        private RichTextBox TextBoxmontoBrutoTotal;
        private RichTextBox TextBoxBrutoEfectivo;
        private Label labelBrutoEfectivo;
        private RichTextBox TextBoxBrutoBanco;
        private Label label1;
        private RichTextBox TextBoxMontoHora;
        private Label label2;
        private Button btnConfirmar;
        private Label labelDni;
        private RichTextBox TextBoxDni;
        private RichTextBox TextBoxNombres;
        private Label labelNombre;
        private RichTextBox TextBoxModalidad;
        private Label label3;
        private Label label4;
    }
}