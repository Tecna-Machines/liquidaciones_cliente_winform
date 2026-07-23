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
            radioButtonOficial = new RadioButton();
            radioButtonInterno = new RadioButton();
            label5 = new Label();
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
            panel1 = new Panel();
            groupBoxPagoLiquidacion.SuspendLayout();
            groupBoxContab.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPagoLiquidacion
            // 
            groupBoxPagoLiquidacion.Controls.Add(panel1);
            groupBoxPagoLiquidacion.Controls.Add(label5);
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
            groupBoxPagoLiquidacion.Size = new Size(464, 232);
            groupBoxPagoLiquidacion.TabIndex = 0;
            groupBoxPagoLiquidacion.TabStop = false;
            groupBoxPagoLiquidacion.Text = "PAGO INTERNO";
            // 
            // radioButtonOficial
            // 
            radioButtonOficial.AutoSize = true;
            radioButtonOficial.Dock = DockStyle.Right;
            radioButtonOficial.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButtonOficial.Location = new Point(97, 0);
            radioButtonOficial.Name = "radioButtonOficial";
            radioButtonOficial.Size = new Size(68, 34);
            radioButtonOficial.TabIndex = 11;
            radioButtonOficial.TabStop = true;
            radioButtonOficial.Text = "oficial";
            radioButtonOficial.UseVisualStyleBackColor = true;
            // 
            // radioButtonInterno
            // 
            radioButtonInterno.AutoSize = true;
            radioButtonInterno.Dock = DockStyle.Fill;
            radioButtonInterno.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButtonInterno.Location = new Point(0, 0);
            radioButtonInterno.Name = "radioButtonInterno";
            radioButtonInterno.Size = new Size(165, 34);
            radioButtonInterno.TabIndex = 10;
            radioButtonInterno.TabStop = true;
            radioButtonInterno.Text = "interno";
            radioButtonInterno.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.Location = new Point(30, 120);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 9;
            label5.Text = "Pertence a:";
            // 
            // comboBoxDescripcion
            // 
            comboBoxDescripcion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            comboBoxDescripcion.FormattingEnabled = true;
            comboBoxDescripcion.Location = new Point(134, 158);
            comboBoxDescripcion.Name = "comboBoxDescripcion";
            comboBoxDescripcion.Size = new Size(308, 28);
            comboBoxDescripcion.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.Location = new Point(18, 160);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 6;
            label3.Text = "Descripcion :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(72, 76);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 4;
            label1.Text = "Tipo:";
            // 
            // radioButtonEfectivo
            // 
            radioButtonEfectivo.AutoSize = true;
            radioButtonEfectivo.BackColor = SystemColors.ActiveCaption;
            radioButtonEfectivo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            radioButtonEfectivo.Location = new Point(277, 75);
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
            radioButtonTransferencia.Location = new Point(134, 75);
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
            textBoxMonto.Location = new Point(134, 29);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(198, 31);
            textBoxMonto.TabIndex = 1;
            textBoxMonto.TextChanged += TextBoxMonto_TextChanged;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            labelMonto.Location = new Point(56, 34);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(60, 20);
            labelMonto.TabIndex = 0;
            labelMonto.Text = "Monto:";
            // 
            // groupBoxContab
            // 
            groupBoxContab.Controls.Add(label4);
            groupBoxContab.Controls.Add(comboBoxCuentasContables);
            groupBoxContab.Controls.Add(label2);
            groupBoxContab.Controls.Add(textBoxMontoContab);
            groupBoxContab.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBoxContab.Location = new Point(12, 250);
            groupBoxContab.Name = "groupBoxContab";
            groupBoxContab.Size = new Size(464, 189);
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
            BtnPagar.Location = new Point(161, 461);
            BtnPagar.Name = "BtnPagar";
            BtnPagar.Size = new Size(149, 46);
            BtnPagar.TabIndex = 2;
            BtnPagar.Text = "CONFIRMAR PAGO";
            BtnPagar.UseVisualStyleBackColor = false;
            BtnPagar.Click += BtnPagar_Click;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(30, 461);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(389, 32);
            progressBar.TabIndex = 3;
            progressBar.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(radioButtonOficial);
            panel1.Controls.Add(radioButtonInterno);
            panel1.Location = new Point(133, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(165, 34);
            panel1.TabIndex = 12;
            // 
            // CargarPagosForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(488, 541);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Label label5;
        private RadioButton radioButtonOficial;
        private RadioButton radioButtonInterno;
        private Panel panel1;
    }
}