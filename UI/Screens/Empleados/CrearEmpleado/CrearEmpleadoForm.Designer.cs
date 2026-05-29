namespace UI.Screens.CrearEmpleado
{
    partial class CrearEmpleadoForm
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
            textBoxDni = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxNombres = new TextBox();
            label3 = new Label();
            textBoxApellidos = new TextBox();
            fechaIngreso = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            fechaAlta = new DateTimePicker();
            label6 = new Label();
            fechaNacimiento = new DateTimePicker();
            BtnConfirmarCrear = new Button();
            label7 = new Label();
            textBoxCuilDni = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxCuilUltimoDigito = new TextBox();
            textBoxCuilPrimerDigito = new TextBox();
            SuspendLayout();
            // 
            // textBoxDni
            // 
            textBoxDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDni.Location = new Point(130, 67);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(222, 25);
            textBoxDni.TabIndex = 0;
            textBoxDni.TextChanged += textBoxDni_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(72, 71);
            label1.Name = "label1";
            label1.Size = new Size(36, 16);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(21, 196);
            label2.Name = "label2";
            label2.Size = new Size(87, 16);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE/S:";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombres.Location = new Point(130, 192);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(222, 25);
            textBoxNombres.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(12, 249);
            label3.Name = "label3";
            label3.Size = new Size(96, 16);
            label3.TabIndex = 5;
            label3.Text = "APELLIDO/S:";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellidos.Location = new Point(130, 245);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(222, 25);
            textBoxApellidos.TabIndex = 4;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(532, 67);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(222, 25);
            fechaIngreso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(407, 71);
            label4.Name = "label4";
            label4.Size = new Size(93, 16);
            label4.TabIndex = 7;
            label4.Text = "F. INGRESO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(425, 133);
            label5.Name = "label5";
            label5.Size = new Size(75, 16);
            label5.TabIndex = 9;
            label5.Text = "F. ALTA:  ";
            // 
            // fechaAlta
            // 
            fechaAlta.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fechaAlta.Format = DateTimePickerFormat.Short;
            fechaAlta.Location = new Point(532, 129);
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Size = new Size(222, 25);
            fechaAlta.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(382, 196);
            label6.Name = "label6";
            label6.Size = new Size(118, 16);
            label6.TabIndex = 11;
            label6.Text = "F. NACIMIENTO:";
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            fechaNacimiento.Format = DateTimePickerFormat.Short;
            fechaNacimiento.Location = new Point(532, 192);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(222, 25);
            fechaNacimiento.TabIndex = 10;
            // 
            // BtnConfirmarCrear
            // 
            BtnConfirmarCrear.BackColor = Color.Orange;
            BtnConfirmarCrear.Cursor = Cursors.Hand;
            BtnConfirmarCrear.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            BtnConfirmarCrear.Location = new Point(532, 249);
            BtnConfirmarCrear.Name = "BtnConfirmarCrear";
            BtnConfirmarCrear.Size = new Size(222, 60);
            BtnConfirmarCrear.TabIndex = 12;
            BtnConfirmarCrear.Text = "CREAR EMPLEADO";
            BtnConfirmarCrear.UseVisualStyleBackColor = false;
            BtnConfirmarCrear.Click += BtnConfirmarCrear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SansSerif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(63, 133);
            label7.Name = "label7";
            label7.Size = new Size(45, 16);
            label7.TabIndex = 13;
            label7.Text = "CUIL:";
            // 
            // textBoxCuilDni
            // 
            textBoxCuilDni.BackColor = SystemColors.ButtonHighlight;
            textBoxCuilDni.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCuilDni.Location = new Point(179, 124);
            textBoxCuilDni.Name = "textBoxCuilDni";
            textBoxCuilDni.ReadOnly = true;
            textBoxCuilDni.Size = new Size(124, 25);
            textBoxCuilDni.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(182, 25);
            label8.TabIndex = 15;
            label8.Text = "CREAR EMPLEADO:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 318);
            label9.Name = "label9";
            label9.Size = new Size(331, 15);
            label9.TabIndex = 16;
            label9.Text = "Nota: la fecha de ingreso se utiliza para calcular la antiguedad";
            // 
            // textBoxCuilSegundoDigito
            // 
            textBoxCuilUltimoDigito.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCuilUltimoDigito.Location = new Point(309, 124);
            textBoxCuilUltimoDigito.Name = "textBoxCuilSegundoDigito";
            textBoxCuilUltimoDigito.Size = new Size(43, 25);
            textBoxCuilUltimoDigito.TabIndex = 17;
            textBoxCuilUltimoDigito.Text = "9";
            // 
            // textBoxCuilPrimerDigito
            // 
            textBoxCuilPrimerDigito.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCuilPrimerDigito.Location = new Point(130, 124);
            textBoxCuilPrimerDigito.Name = "textBoxCuilPrimerDigito";
            textBoxCuilPrimerDigito.Size = new Size(43, 25);
            textBoxCuilPrimerDigito.TabIndex = 18;
            textBoxCuilPrimerDigito.Text = "9";
            // 
            // CrearEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 342);
            Controls.Add(textBoxCuilPrimerDigito);
            Controls.Add(textBoxCuilUltimoDigito);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(textBoxCuilDni);
            Controls.Add(label7);
            Controls.Add(BtnConfirmarCrear);
            Controls.Add(label6);
            Controls.Add(fechaNacimiento);
            Controls.Add(label5);
            Controls.Add(fechaAlta);
            Controls.Add(label4);
            Controls.Add(fechaIngreso);
            Controls.Add(label3);
            Controls.Add(textBoxApellidos);
            Controls.Add(label2);
            Controls.Add(textBoxNombres);
            Controls.Add(label1);
            Controls.Add(textBoxDni);
            Name = "CrearEmpleadoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CrearEmpleadoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDni;
        private Label label1;
        private Label label2;
        private TextBox textBoxNombres;
        private Label label3;
        private TextBox textBoxApellidos;
        private DateTimePicker fechaIngreso;
        private Label label4;
        private Label label5;
        private DateTimePicker fechaAlta;
        private Label label6;
        private DateTimePicker fechaNacimiento;
        private Button BtnConfirmarCrear;
        private Label label7;
        private TextBox textBoxCuilDni;
        private Label label8;
        private Label label9;
        private TextBox textBoxCuilUltimoDigito;
        private TextBox textBoxCuilPrimerDigito;
    }
}