namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    partial class pagos
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
            groupBoxPagoLiquidacion = new GroupBox();
            label1 = new Label();
            radioButtonEfectivo = new RadioButton();
            radioButtonTransferencia = new RadioButton();
            textBoxMonto = new TextBox();
            labelMonto = new Label();
            groupBoxContab = new GroupBox();
            label2 = new Label();
            textBoxMontoContab = new TextBox();
            buttonPagar = new Button();
            textBoxDescripcion = new TextBox();
            label3 = new Label();
            groupBoxPagoLiquidacion.SuspendLayout();
            groupBoxContab.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPagoLiquidacion
            // 
            groupBoxPagoLiquidacion.Controls.Add(label3);
            groupBoxPagoLiquidacion.Controls.Add(textBoxDescripcion);
            groupBoxPagoLiquidacion.Controls.Add(label1);
            groupBoxPagoLiquidacion.Controls.Add(radioButtonEfectivo);
            groupBoxPagoLiquidacion.Controls.Add(radioButtonTransferencia);
            groupBoxPagoLiquidacion.Controls.Add(textBoxMonto);
            groupBoxPagoLiquidacion.Controls.Add(labelMonto);
            groupBoxPagoLiquidacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPagoLiquidacion.Location = new Point(12, 12);
            groupBoxPagoLiquidacion.Name = "groupBoxPagoLiquidacion";
            groupBoxPagoLiquidacion.Size = new Size(434, 222);
            groupBoxPagoLiquidacion.TabIndex = 0;
            groupBoxPagoLiquidacion.TabStop = false;
            groupBoxPagoLiquidacion.Text = "PAGO INTERNO";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(45, 92);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 4;
            label1.Text = "TIPO:";
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.BackColor = SystemColors.ActiveCaption;
            radioButtonEfectivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonEfectivo.Location = new Point(119, 130);
            radioButtonEfectivo.Name = "radioButtonEfectivo";
            radioButtonEfectivo.Size = new Size(89, 23);
            radioButtonEfectivo.TabIndex = 3;
            radioButtonEfectivo.TabStop = true;
            radioButtonEfectivo.Text = "EFECTIVO";
            radioButtonEfectivo.UseVisualStyleBackColor = false;
            // 
            // radioButtonTransferencia
            // 
            radioButtonTransferencia.AutoSize = true;
            radioButtonTransferencia.BackColor = SystemColors.ActiveCaption;
            radioButtonTransferencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonTransferencia.Location = new Point(119, 92);
            radioButtonTransferencia.Name = "radioButtonTransferencia";
            radioButtonTransferencia.Size = new Size(137, 23);
            radioButtonTransferencia.TabIndex = 2;
            radioButtonTransferencia.TabStop = true;
            radioButtonTransferencia.Text = "TRANSFERENCIA";
            radioButtonTransferencia.UseVisualStyleBackColor = false;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMonto.Location = new Point(112, 42);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(198, 31);
            textBoxMonto.TabIndex = 1;
            textBoxMonto.TextChanged += TextBoxMonto_TextChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.Location = new Point(18, 45);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(86, 25);
            labelMonto.TabIndex = 0;
            labelMonto.Text = "MONTO:";
            // 
            // groupBoxContab
            // 
            groupBoxContab.Controls.Add(label2);
            groupBoxContab.Controls.Add(textBoxMontoContab);
            groupBoxContab.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxContab.Location = new Point(12, 240);
            groupBoxContab.Name = "groupBoxContab";
            groupBoxContab.Size = new Size(434, 202);
            groupBoxContab.TabIndex = 1;
            groupBoxContab.TabStop = false;
            groupBoxContab.Text = "COPIA PARA CONTAB";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(18, 28);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 5;
            label2.Text = "MONTO:";
            // 
            // textBoxMontoContab
            // 
            textBoxMontoContab.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoContab.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMontoContab.ForeColor = Color.YellowGreen;
            textBoxMontoContab.Location = new Point(112, 25);
            textBoxMontoContab.Name = "textBoxMontoContab";
            textBoxMontoContab.ReadOnly = true;
            textBoxMontoContab.Size = new Size(198, 31);
            textBoxMontoContab.TabIndex = 2;
            // 
            // buttonPagar
            // 
            buttonPagar.BackColor = Color.LimeGreen;
            buttonPagar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPagar.Location = new Point(155, 457);
            buttonPagar.Name = "buttonPagar";
            buttonPagar.Size = new Size(149, 46);
            buttonPagar.TabIndex = 2;
            buttonPagar.Text = "CONFIRMAR PAGO";
            buttonPagar.UseVisualStyleBackColor = false;
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDescripcion.Location = new Point(112, 174);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(198, 27);
            textBoxDescripcion.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion :";
            // 
            // pagos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(473, 531);
            Controls.Add(buttonPagar);
            Controls.Add(groupBoxContab);
            Controls.Add(groupBoxPagoLiquidacion);
            Name = "pagos";
            Text = "pagos";
            groupBoxPagoLiquidacion.ResumeLayout(false);
            groupBoxPagoLiquidacion.PerformLayout();
            groupBoxContab.ResumeLayout(false);
            groupBoxContab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPagoLiquidacion;
        private GroupBox groupBoxContab;
        private TextBox textBoxMonto;
        private Label labelMonto;
        private TextBox textBoxMontoContab;
        private Label label1;
        private RadioButton radioButtonEfectivo;
        private RadioButton radioButtonTransferencia;
        private Label label2;
        private Button buttonPagar;
        private Label label3;
        private TextBox textBoxDescripcion;
    }
}