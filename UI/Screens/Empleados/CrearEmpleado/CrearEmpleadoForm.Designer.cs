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
            label9 = new Label();
            textBoxCuilUltimoDigito = new TextBox();
            textBoxCuilPrimerDigito = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // textBoxDni
            // 
            textBoxDni.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxDni.Location = new Point(111, 46);
            textBoxDni.Name = "textBoxDni";
            textBoxDni.Size = new Size(222, 20);
            textBoxDni.TabIndex = 0;
            textBoxDni.TextChanged += textBoxDni_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 8.25F);
            label1.Location = new Point(11, 50);
            label1.Name = "label1";
            label1.Size = new Size(29, 13);
            label1.TabIndex = 1;
            label1.Text = "DNI:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 8.25F);
            label2.Location = new Point(11, 85);
            label2.Name = "label2";
            label2.Size = new Size(69, 13);
            label2.TabIndex = 3;
            label2.Text = "NOMBRE/S:";
            // 
            // textBoxNombres
            // 
            textBoxNombres.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxNombres.Location = new Point(111, 81);
            textBoxNombres.Name = "textBoxNombres";
            textBoxNombres.Size = new Size(222, 20);
            textBoxNombres.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 8.25F);
            label3.Location = new Point(11, 120);
            label3.Name = "label3";
            label3.Size = new Size(74, 13);
            label3.TabIndex = 5;
            label3.Text = "APELLIDO/S:";
            // 
            // textBoxApellidos
            // 
            textBoxApellidos.Font = new Font("Microsoft Sans Serif", 8.25F);
            textBoxApellidos.Location = new Point(111, 116);
            textBoxApellidos.Name = "textBoxApellidos";
            textBoxApellidos.Size = new Size(222, 20);
            textBoxApellidos.TabIndex = 4;
            // 
            // fechaIngreso
            // 
            fechaIngreso.Font = new Font("Microsoft Sans Serif", 8.25F);
            fechaIngreso.Format = DateTimePickerFormat.Short;
            fechaIngreso.Location = new Point(111, 151);
            fechaIngreso.Name = "fechaIngreso";
            fechaIngreso.Size = new Size(222, 20);
            fechaIngreso.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(11, 155);
            label4.Name = "label4";
            label4.Size = new Size(71, 13);
            label4.TabIndex = 7;
            label4.Text = "F. INGRESO:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 8.25F);
            label5.Location = new Point(11, 190);
            label5.Name = "label5";
            label5.Size = new Size(55, 13);
            label5.TabIndex = 9;
            label5.Text = "F. ALTA:  ";
            // 
            // fechaAlta
            // 
            fechaAlta.Font = new Font("Microsoft Sans Serif", 8.25F);
            fechaAlta.Format = DateTimePickerFormat.Short;
            fechaAlta.Location = new Point(111, 186);
            fechaAlta.Name = "fechaAlta";
            fechaAlta.Size = new Size(222, 20);
            fechaAlta.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 8.25F);
            label6.Location = new Point(11, 225);
            label6.Name = "label6";
            label6.Size = new Size(89, 13);
            label6.TabIndex = 11;
            label6.Text = "F. NACIMIENTO:";
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.Font = new Font("Microsoft Sans Serif", 8.25F);
            fechaNacimiento.Format = DateTimePickerFormat.Short;
            fechaNacimiento.Location = new Point(111, 221);
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.Size = new Size(222, 20);
            fechaNacimiento.TabIndex = 10;
            // 
            // BtnConfirmarCrear
            // 
            BtnConfirmarCrear.BackColor = Color.PaleGreen;
            BtnConfirmarCrear.Cursor = Cursors.Hand;
            BtnConfirmarCrear.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            BtnConfirmarCrear.Location = new Point(131, 287);
            BtnConfirmarCrear.Name = "BtnConfirmarCrear";
            BtnConfirmarCrear.Size = new Size(202, 43);
            BtnConfirmarCrear.TabIndex = 12;
            BtnConfirmarCrear.Text = "CREAR EMPLEADO";
            BtnConfirmarCrear.UseVisualStyleBackColor = false;
            BtnConfirmarCrear.Click += BtnConfirmarCrear_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("SansSerif", 10F, FontStyle.Bold);
            label7.Location = new Point(12, 12);
            label7.Name = "label7";
            label7.Size = new Size(45, 16);
            label7.TabIndex = 13;
            label7.Text = "CUIL:";
            // 
            // textBoxCuilDni
            // 
            textBoxCuilDni.BackColor = SystemColors.Info;
            textBoxCuilDni.Font = new Font("Segoe UI", 10F);
            textBoxCuilDni.Location = new Point(111, 8);
            textBoxCuilDni.Name = "textBoxCuilDni";
            textBoxCuilDni.ReadOnly = true;
            textBoxCuilDni.Size = new Size(124, 25);
            textBoxCuilDni.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.HotTrack;
            label9.Location = new Point(2, 249);
            label9.Name = "label9";
            label9.Size = new Size(331, 15);
            label9.TabIndex = 16;
            label9.Text = "Nota: la fecha de ingreso se utiliza para calcular la antiguedad";
            // 
            // textBoxCuilUltimoDigito
            // 
            textBoxCuilUltimoDigito.BackColor = SystemColors.Info;
            textBoxCuilUltimoDigito.Font = new Font("Segoe UI", 10F);
            textBoxCuilUltimoDigito.Location = new Point(241, 8);
            textBoxCuilUltimoDigito.Name = "textBoxCuilUltimoDigito";
            textBoxCuilUltimoDigito.Size = new Size(43, 25);
            textBoxCuilUltimoDigito.TabIndex = 17;
            textBoxCuilUltimoDigito.Text = "9";
            // 
            // textBoxCuilPrimerDigito
            // 
            textBoxCuilPrimerDigito.BackColor = SystemColors.Info;
            textBoxCuilPrimerDigito.Font = new Font("Segoe UI", 10F);
            textBoxCuilPrimerDigito.Location = new Point(62, 8);
            textBoxCuilPrimerDigito.Name = "textBoxCuilPrimerDigito";
            textBoxCuilPrimerDigito.Size = new Size(43, 25);
            textBoxCuilPrimerDigito.TabIndex = 18;
            textBoxCuilPrimerDigito.Text = "9";
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.FixedSingle;
            label8.Location = new Point(3, 39);
            label8.Name = "label8";
            label8.Size = new Size(500, 1);
            label8.TabIndex = 19;
            // 
            // CrearEmpleadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 342);
            Controls.Add(label8);
            Controls.Add(textBoxCuilPrimerDigito);
            Controls.Add(textBoxCuilUltimoDigito);
            Controls.Add(label9);
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
            Text = "Datos empleado";
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
        private Label label9;
        private TextBox textBoxCuilUltimoDigito;
        private TextBox textBoxCuilPrimerDigito;
        private Label label8;
    }
}