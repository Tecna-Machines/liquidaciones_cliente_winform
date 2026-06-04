namespace UI
{
    partial class PeriodoLiquiComponent
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnConfirmarPeriodo = new Button();
            panelPeriodo = new Panel();
            comboBoxYear = new ComboBox();
            labelAnio = new Label();
            comboBoxMeses = new ComboBox();
            periodoSegunQuincena = new Label();
            periodoPrimerQuincena = new Label();
            labelFecha = new Label();
            btnSegQuincena = new Button();
            btnPrimerQuincena = new Button();
            panelPeriodo.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(157, 11);
            label1.Name = "label1";
            label1.Size = new Size(189, 28);
            label1.TabIndex = 2;
            label1.Text = "💰 Liquidacion 💰";
            // 
            // btnConfirmarPeriodo
            // 
            btnConfirmarPeriodo.BackColor = SystemColors.MenuHighlight;
            btnConfirmarPeriodo.Cursor = Cursors.Hand;
            btnConfirmarPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarPeriodo.ForeColor = SystemColors.ButtonHighlight;
            btnConfirmarPeriodo.Location = new Point(76, 149);
            btnConfirmarPeriodo.Name = "btnConfirmarPeriodo";
            btnConfirmarPeriodo.Size = new Size(320, 38);
            btnConfirmarPeriodo.TabIndex = 3;
            btnConfirmarPeriodo.Text = "EMPEZAR A LIQUIDAR";
            btnConfirmarPeriodo.UseVisualStyleBackColor = false;
            btnConfirmarPeriodo.Click += ClickBtnConfirmarPeriodo;
            // 
            // panelPeriodo
            // 
            panelPeriodo.Controls.Add(comboBoxYear);
            panelPeriodo.Controls.Add(btnConfirmarPeriodo);
            panelPeriodo.Controls.Add(labelAnio);
            panelPeriodo.Controls.Add(comboBoxMeses);
            panelPeriodo.Controls.Add(periodoSegunQuincena);
            panelPeriodo.Controls.Add(periodoPrimerQuincena);
            panelPeriodo.Controls.Add(labelFecha);
            panelPeriodo.Controls.Add(btnSegQuincena);
            panelPeriodo.Controls.Add(btnPrimerQuincena);
            panelPeriodo.Location = new Point(3, 52);
            panelPeriodo.Name = "panelPeriodo";
            panelPeriodo.Size = new Size(539, 208);
            panelPeriodo.TabIndex = 5;
            // 
            // comboBoxYear
            // 
            comboBoxYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(76, 96);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(121, 23);
            comboBoxYear.TabIndex = 7;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAnio.Location = new Point(18, 100);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(36, 15);
            labelAnio.TabIndex = 6;
            labelAnio.Text = "AÑO:";
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(76, 46);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(121, 23);
            comboBoxMeses.TabIndex = 5;
            comboBoxMeses.SelectedIndexChanged += InputMesCambio;
            // 
            // periodoSegunQuincena
            // 
            periodoSegunQuincena.AutoSize = true;
            periodoSegunQuincena.Font = new Font("Cascadia Code SemiBold", 9F);
            periodoSegunQuincena.Location = new Point(418, 101);
            periodoSegunQuincena.Name = "periodoSegunQuincena";
            periodoSegunQuincena.Size = new Size(77, 16);
            periodoSegunQuincena.TabIndex = 4;
            periodoSegunQuincena.Text = "(00 al 00)";
            // 
            // periodoPrimerQuincena
            // 
            periodoPrimerQuincena.AutoSize = true;
            periodoPrimerQuincena.Font = new Font("Cascadia Code SemiBold", 9F);
            periodoPrimerQuincena.Location = new Point(418, 49);
            periodoPrimerQuincena.Name = "periodoPrimerQuincena";
            periodoPrimerQuincena.Size = new Size(77, 16);
            periodoPrimerQuincena.TabIndex = 3;
            periodoPrimerQuincena.Text = "(00 al 00)";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelFecha.Location = new Point(18, 50);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(34, 15);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "MES:";
            // 
            // btnSegQuincena
            // 
            btnSegQuincena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSegQuincena.Location = new Point(239, 86);
            btnSegQuincena.Name = "btnSegQuincena";
            btnSegQuincena.Size = new Size(157, 45);
            btnSegQuincena.TabIndex = 1;
            btnSegQuincena.Text = "2da quincena";
            btnSegQuincena.UseVisualStyleBackColor = true;
            btnSegQuincena.Click += ClickBtnSegundaQuicena;
            // 
            // btnPrimerQuincena
            // 
            btnPrimerQuincena.BackColor = SystemColors.ButtonHighlight;
            btnPrimerQuincena.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnPrimerQuincena.Location = new Point(239, 33);
            btnPrimerQuincena.Name = "btnPrimerQuincena";
            btnPrimerQuincena.Size = new Size(157, 47);
            btnPrimerQuincena.TabIndex = 0;
            btnPrimerQuincena.Text = "1ra quincena";
            btnPrimerQuincena.UseVisualStyleBackColor = false;
            btnPrimerQuincena.Click += ClickBtnPrimerQuincena;
            // 
            // PeriodoLiquiComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPeriodo);
            Controls.Add(label1);
            Name = "PeriodoLiquiComponent";
            Size = new Size(542, 284);
            panelPeriodo.ResumeLayout(false);
            panelPeriodo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnConfirmarPeriodo;
        private Panel panelPeriodo;
        private Label labelFecha;
        private Button btnSegQuincena;
        private Button btnPrimerQuincena;
        private Label periodoSegunQuincena;
        private Label periodoPrimerQuincena;
        private Label labelAnio;
        private ComboBox comboBoxMeses;
        private ComboBox comboBoxYear;
    }
}
