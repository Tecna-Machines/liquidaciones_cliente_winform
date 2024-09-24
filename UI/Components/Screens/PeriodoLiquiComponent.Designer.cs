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
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(137, 24);
            label1.Name = "label1";
            label1.Size = new Size(256, 28);
            label1.TabIndex = 2;
            label1.Text = "Elige el periodo a liquidar";
            // 
            // btnConfirmarPeriodo
            // 
            btnConfirmarPeriodo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnConfirmarPeriodo.Location = new Point(194, 235);
            btnConfirmarPeriodo.Name = "btnConfirmarPeriodo";
            btnConfirmarPeriodo.Size = new Size(157, 38);
            btnConfirmarPeriodo.TabIndex = 3;
            btnConfirmarPeriodo.Text = "CONFIRMAR PERIODO";
            btnConfirmarPeriodo.UseVisualStyleBackColor = true;
            btnConfirmarPeriodo.Click += ClickBtnConfirmarPeriodo;
            // 
            // PeriodoLiquiComponent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnConfirmarPeriodo);
            Controls.Add(label1);
            Controls.Add(calendarioFechaFin);
            Controls.Add(calendarioFechaInicio);
            Name = "PeriodoLiquiComponent";
            Size = new Size(542, 284);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendarioFechaInicio;
        private MonthCalendar calendarioFechaFin;
        private Label label1;
        private Button btnConfirmarPeriodo;
    }
}
