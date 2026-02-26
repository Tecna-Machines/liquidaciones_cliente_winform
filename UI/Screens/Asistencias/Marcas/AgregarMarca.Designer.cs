namespace UI.Screens.Asistencias.Marcas
{
    partial class AgregarMarca
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
            labelDni = new Label();
            textBoxDni = new TextBox();
            datePickerIngreso = new DateTimePicker();
            datePickerEgreso = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // labelDni
            // 
            labelDni.AutoSize = true;
            labelDni.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDni.Location = new Point(38, 16);
            labelDni.Name = "labelDni";
            labelDni.Size = new Size(32, 15);
            labelDni.TabIndex = 0;
            labelDni.Text = "DNI:";
            // 
            // textBoxDni
            // 
            textBoxDni.BackColor = SystemColors.ButtonHighlight;
            textBoxDni.Location = new Point(74, 12);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.ReadOnly = true;
            textBoxDni.Size = new Size(200, 23);
            textBoxDni.TabIndex = 1;
            // 
            // datePickerIngreso
            // 
            datePickerIngreso.Location = new Point(74, 53);
            datePickerIngreso.Name = "datePickerIngreso";
            datePickerIngreso.Size = new Size(200, 23);
            datePickerIngreso.TabIndex = 2;
            // 
            // datePickerEgreso
            // 
            datePickerEgreso.Location = new Point(74, 96);
            datePickerEgreso.Name = "datePickerEgreso";
            datePickerEgreso.Size = new Size(200, 23);
            datePickerEgreso.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(10, 57);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "INGRESO:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(16, 100);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "EGRESO:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(123, 131);
            button1.Name = "button1";
            button1.Size = new Size(104, 36);
            button1.TabIndex = 6;
            button1.Text = "CREAR";
            button1.UseVisualStyleBackColor = false;
            // 
            // AgregarMarca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 179);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(datePickerEgreso);
            Controls.Add(datePickerIngreso);
            Controls.Add(textBoxDni);
            Controls.Add(labelDni);
            Name = "AgregarMarca";
            Text = "AgregarMarca";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDni;
        private TextBox textBoxDni;
        private DateTimePicker datePickerIngreso;
        private DateTimePicker datePickerEgreso;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}