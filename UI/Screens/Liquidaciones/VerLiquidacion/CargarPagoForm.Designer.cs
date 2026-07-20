namespace UI.Screens.Liquidaciones.VerLiquidacion
{
    partial class CargarPagosForm
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
            comboBoxDescripcion = new ComboBox();
            label3 = new Label();
            label1 = new Label();
            radioButtonEfectivo = new RadioButton();
            radioButtonTransferencia = new RadioButton();
            textBoxMonto = new TextBox();
            labelMonto = new Label();
            groupBoxContab = new GroupBox();
            label4 = new Label();
            comboBoxCuentasContables = new ComboBox();
            label2 = new Label();
            textBoxMontoContab = new TextBox();
            BtnPagar = new Button();
            progressBar = new ProgressBar();
            groupBoxPagoLiquidacion.SuspendLayout();
            groupBoxContab.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPagoLiquidacion
            // 
            groupBoxPagoLiquidacion.Controls.Add(comboBoxDescripcion);
            groupBoxPagoLiquidacion.Controls.Add(label3);
            groupBoxPagoLiquidacion.Controls.Add(label1);
            groupBoxPagoLiquidacion.Controls.Add(radioButtonEfectivo);
            groupBoxPagoLiquidacion.Controls.Add(radioButtonTransferencia);
            groupBoxPagoLiquidacion.Controls.Add(textBoxMonto);
            groupBoxPagoLiquidacion.Controls.Add(labelMonto);
            groupBoxPagoLiquidacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxPagoLiquidacion.Location = new Point(12, 12);
            groupBoxPagoLiquidacion.Name = "groupBoxPagoLiquidacion";
            groupBoxPagoLiquidacion.Size = new Size(434, 222);
            groupBoxPagoLiquidacion.TabIndex = 0;
            groupBoxPagoLiquidacion.TabStop = false;
            groupBoxPagoLiquidacion.Text = "PAGO INTERNO";
            // 
            // comboBoxDescripcion
            // 
            comboBoxDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBoxDescripcion.FormattingEnabled = true;
            comboBoxDescripcion.Location = new Point(112, 173);
            comboBoxDescripcion.Name = "comboBoxDescripcion";
            comboBoxDescripcion.Size = new Size(273, 28);
            comboBoxDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(6, 177);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
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
            radioButtonEfectivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
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
            radioButtonTransferencia.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButtonTransferencia.Location = new Point(119, 92);
            radioButtonTransferencia.Name = "radioButtonTransferencia";
            radioButtonTransferencia.Size = new Size(137, 23);
            radioButtonTransferencia.TabIndex = 2;
            radioButtonTransferencia.TabStop = true;
            radioButtonTransferencia.Text = "TRANSFERENCIA";
            radioButtonTransferencia.UseVisualStyleBackColor = false;
            radioButtonTransferencia.CheckedChanged += RadioButtonTransferencia_CheckedChanged;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            textBoxMonto.Location = new Point(112, 42);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(198, 31);
            textBoxMonto.TabIndex = 1;
            textBoxMonto.TextChanged += TextBoxMonto_TextChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            labelMonto.Location = new Point(18, 45);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(86, 25);
            labelMonto.TabIndex = 0;
            labelMonto.Text = "MONTO:";
            // 
            // groupBoxContab
            // 
            groupBoxContab.Controls.Add(label4);
            groupBoxContab.Controls.Add(comboBoxCuentasContables);
            groupBoxContab.Controls.Add(label2);
            groupBoxContab.Controls.Add(textBoxMontoContab);
            groupBoxContab.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxContab.Location = new Point(12, 240);
            groupBoxContab.Name = "groupBoxContab";
            groupBoxContab.Size = new Size(434, 169);
            groupBoxContab.TabIndex = 1;
            groupBoxContab.TabStop = false;
            groupBoxContab.Text = "COPIA PARA CONTAB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.Location = new Point(17, 108);
            label4.Name = "label4";
            label4.Size = new Size(70, 20);
            label4.TabIndex = 7;
            label4.Text = "ORIGEN:";
            // 
            // comboBoxCuentasContables
            // 
            comboBoxCuentasContables.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxCuentasContables.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBoxCuentasContables.FormattingEnabled = true;
            comboBoxCuentasContables.Location = new Point(112, 104);
            comboBoxCuentasContables.MaxDropDownItems = 5;
            comboBoxCuentasContables.Name = "comboBoxCuentasContables";
            comboBoxCuentasContables.Size = new Size(273, 28);
            comboBoxCuentasContables.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label2.Location = new Point(18, 60);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "MONTO:";
            // 
            // textBoxMontoContab
            // 
            textBoxMontoContab.BackColor = SystemColors.ButtonHighlight;
            textBoxMontoContab.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            textBoxMontoContab.ForeColor = Color.YellowGreen;
            textBoxMontoContab.Location = new Point(112, 57);
            textBoxMontoContab.Name = "textBoxMontoContab";
            textBoxMontoContab.ReadOnly = true;
            textBoxMontoContab.Size = new Size(273, 27);
            textBoxMontoContab.TabIndex = 2;
            // 
            // BtnPagar
            // 
            BtnPagar.BackColor = Color.LimeGreen;
            BtnPagar.Cursor = Cursors.Hand;
            BtnPagar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            BtnPagar.Location = new Point(161, 430);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(149, 46);
            BtnPagar.TabIndex = 2;
            BtnPagar.Text = "CONFIRMAR PAGO";
            BtnPagar.UseVisualStyleBackColor = false;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(29, 430);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(389, 32);
            progressBar.TabIndex = 3;
            progressBar.Visible = false;
            // 
            // CargarPagosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(483, 496);
            Controls.Add(progressBar);
            Controls.Add(BtnPagar);
            Controls.Add(groupBoxPagoLiquidacion);
            Controls.Add(groupBoxContab);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CargarPagosForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "pagos";
            Load += CargarPagosForm_Load;
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
        private Button BtnPagar;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxCuentasContables;
        private ProgressBar progressBar;
        private ComboBox comboBoxDescripcion;
    }
}