namespace UI.Screens.Feriados.CrearFeriado
{
    partial class CrearFeriadoForm
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
            descripcionFeriado = new TextBox();
            label1 = new Label();
            fechaFeriado = new DateTimePicker();
            checkBoxSeRepite = new CheckBox();
            label2 = new Label();
            BtnCargarFeriado = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // descripcionFeriado
            // 
            descripcionFeriado.Location = new Point(109, 117);
            descripcionFeriado.Name = "descripcionFeriado";
            descripcionFeriado.Size = new Size(205, 23);
            descripcionFeriado.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 121);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 1;
            label1.Text = "Descripcion:";
            // 
            // fechaFeriado
            // 
            fechaFeriado.Location = new Point(109, 76);
            fechaFeriado.Name = "fechaFeriado";
            fechaFeriado.Size = new Size(205, 23);
            fechaFeriado.TabIndex = 2;
            // 
            // checkBoxSeRepite
            // 
            checkBoxSeRepite.AutoSize = true;
            checkBoxSeRepite.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxSeRepite.Location = new Point(109, 162);
            checkBoxSeRepite.Name = "checkBoxSeRepite";
            checkBoxSeRepite.Size = new Size(128, 19);
            checkBoxSeRepite.TabIndex = 3;
            checkBoxSeRepite.Text = "Se repite  siempre";
            checkBoxSeRepite.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(61, 80);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 4;
            label2.Text = "Fecha:";
            // 
            // BtnCargarFeriado
            // 
            BtnCargarFeriado.BackColor = SystemColors.HotTrack;
            BtnCargarFeriado.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCargarFeriado.ForeColor = SystemColors.ButtonHighlight;
            BtnCargarFeriado.Location = new Point(109, 202);
            BtnCargarFeriado.Name = "BtnCargarFeriado";
            BtnCargarFeriado.Size = new Size(101, 46);
            BtnCargarFeriado.TabIndex = 5;
            BtnCargarFeriado.Text = "CREAR";
            BtnCargarFeriado.UseVisualStyleBackColor = false;
            BtnCargarFeriado.Click += BtnCargarFeriado_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(165, 28);
            label3.TabIndex = 6;
            label3.Text = "CREAR FERIADO";
            // 
            // CrearFeriadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 265);
            Controls.Add(label3);
            Controls.Add(BtnCargarFeriado);
            Controls.Add(label2);
            Controls.Add(checkBoxSeRepite);
            Controls.Add(fechaFeriado);
            Controls.Add(label1);
            Controls.Add(descripcionFeriado);
            Name = "CrearFeriadoForm";
            Text = "Crear feriado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox descripcionFeriado;
        private Label label1;
        private DateTimePicker fechaFeriado;
        private CheckBox checkBoxSeRepite;
        private Label label2;
        private Button BtnCargarFeriado;
        private Label label3;
    }
}