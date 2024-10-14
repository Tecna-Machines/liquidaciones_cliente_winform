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
            calendarioFechaInicio = new MonthCalendar();
            calendarioFechaFin = new MonthCalendar();
            label1 = new Label();
            btnConfirmarPeriodo = new Button();
            btnCalendario = new Button();
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
            // calendarioFechaInicio
            // 
            calendarioFechaInicio.Location = new Point(9, 61);
            calendarioFechaInicio.Name = "calendarioFechaInicio";
            calendarioFechaInicio.TabIndex = 0;
            // 
            // calendarioFechaFin
            // 
            calendarioFechaFin.Location = new Point(275, 61);
            calendarioFechaFin.Name = "calendarioFechaFin";
            calendarioFechaFin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 2;
            label1.Text = "Elige el periodo a liquidar";
            // 
            // btnConfirmarPeriodo
            // 
            btnConfirmarPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmarPeriodo.Location = new Point(286, 234);
            btnConfirmarPeriodo.Name = "btnConfirmarPeriodo";
            btnConfirmarPeriodo.Size = new Size(157, 38);
            btnConfirmarPeriodo.TabIndex = 3;
            btnConfirmarPeriodo.Text = "CONFIRMAR PERIODO";
            btnConfirmarPeriodo.UseVisualStyleBackColor = true;
            btnConfirmarPeriodo.Click += ClickBtnConfirmarPeriodo;
            // 
            // btnCalendario
            // 
            btnCalendario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalendario.Location = new Point(100, 235);
            btnCalendario.Name = "btnCalendario";
            btnCalendario.Size = new Size(157, 37);
            btnCalendario.TabIndex = 4;
            btnCalendario.Text = "USAR  CALENDARIO";
            btnCalendario.UseVisualStyleBackColor = true;
            btnCalendario.Click += ClickUsarCalendario;
            // 
            // panelPeriodo
            // 
            panelPeriodo.Controls.Add(comboBoxYear);
            panelPeriodo.Controls.Add(labelAnio);
            panelPeriodo.Controls.Add(comboBoxMeses);
            panelPeriodo.Controls.Add(periodoSegunQuincena);
            panelPeriodo.Controls.Add(periodoPrimerQuincena);
            panelPeriodo.Controls.Add(labelFecha);
            panelPeriodo.Controls.Add(btnSegQuincena);
            panelPeriodo.Controls.Add(btnPrimerQuincena);
            panelPeriodo.Location = new Point(0, 52);
            panelPeriodo.Name = "panelPeriodo";
            panelPeriodo.Size = new Size(539, 177);
            panelPeriodo.TabIndex = 5;
            // 
            // comboBoxYear
            // 
            comboBoxYear.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(150, 106);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(121, 23);
            comboBoxYear.TabIndex = 7;
            // 
            // labelAnio
            // 
            labelAnio.AutoSize = true;
            labelAnio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelAnio.Location = new Point(119, 109);
            labelAnio.Name = "labelAnio";
            labelAnio.Size = new Size(25, 15);
            labelAnio.TabIndex = 6;
            labelAnio.Text = "DE:";
            // 
            // comboBoxMeses
            // 
            comboBoxMeses.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxMeses.FormattingEnabled = true;
            comboBoxMeses.Location = new Point(150, 53);
            comboBoxMeses.Name = "comboBoxMeses";
            comboBoxMeses.Size = new Size(121, 23);
            comboBoxMeses.TabIndex = 5;
            comboBoxMeses.SelectedIndexChanged += InputMesCambio;
            // 
            // periodoSegunQuincena
            // 
            periodoSegunQuincena.AutoSize = true;
            periodoSegunQuincena.Location = new Point(449, 109);
            periodoSegunQuincena.Name = "periodoSegunQuincena";
            periodoSegunQuincena.Size = new Size(54, 15);
            periodoSegunQuincena.TabIndex = 4;
            periodoSegunQuincena.Text = "(00 al 00)";
            // 
            // periodoPrimerQuincena
            // 
            periodoPrimerQuincena.AutoSize = true;
            periodoPrimerQuincena.Location = new Point(449, 56);
            periodoPrimerQuincena.Name = "periodoPrimerQuincena";
            periodoPrimerQuincena.Size = new Size(54, 15);
            periodoPrimerQuincena.TabIndex = 3;
            periodoPrimerQuincena.Text = "(00 al 00)";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelFecha.Location = new Point(92, 61);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(52, 15);
            labelFecha.TabIndex = 2;
            labelFecha.Text = "MES DE:";
            // 
            // btnSegQuincena
            // 
            btnSegQuincena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSegQuincena.Location = new Point(286, 94);
            btnSegQuincena.Name = "btnSegQuincena";
            btnSegQuincena.Size = new Size(152, 45);
            btnSegQuincena.TabIndex = 1;
            btnSegQuincena.Text = "2da quincena";
            btnSegQuincena.UseVisualStyleBackColor = true;
            btnSegQuincena.Click += ClickBtnSegundaQuicena;
            // 
            // btnPrimerQuincena
            // 
            btnPrimerQuincena.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrimerQuincena.Location = new Point(286, 40);
            btnPrimerQuincena.Name = "btnPrimerQuincena";
            btnPrimerQuincena.Size = new Size(157, 47);
            btnPrimerQuincena.TabIndex = 0;
            btnPrimerQuincena.Text = "1ra quincena";
            btnPrimerQuincena.UseVisualStyleBackColor = true;
            btnPrimerQuincena.Click += ClickBtnPrimerQuincena;
            // 
            // PeriodoLiquiComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelPeriodo);
            Controls.Add(btnCalendario);
            Controls.Add(btnConfirmarPeriodo);
            Controls.Add(label1);
            Controls.Add(calendarioFechaFin);
            Controls.Add(calendarioFechaInicio);
            Name = "PeriodoLiquiComponent";
            Size = new Size(542, 284);
            panelPeriodo.ResumeLayout(false);
            panelPeriodo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarioFechaInicio;
        private MonthCalendar calendarioFechaFin;
        private Label label1;
        private Button btnConfirmarPeriodo;
        private Button btnCalendario;
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
