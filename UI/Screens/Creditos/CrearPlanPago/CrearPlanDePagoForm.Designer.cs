namespace UI.Screens.Creditos.CrearPlanPago
{
    partial class CrearPlanDePagoForm
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
            groupBoxPlanPago = new GroupBox();
            comboBoxAnio = new ComboBox();
            comboBoxMes = new ComboBox();
            comboBoxQuincena = new ComboBox();
            label17 = new Label();
            BtnCrearPlan = new Button();
            textBoxMontoCuota = new TextBox();
            label16 = new Label();
            textBoxDebe = new TextBox();
            label15 = new Label();
            label14 = new Label();
            comboBoxCantCuotas = new ComboBox();
            groupBoxPlanPago.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxPlanPago
            // 
            groupBoxPlanPago.Controls.Add(comboBoxAnio);
            groupBoxPlanPago.Controls.Add(comboBoxMes);
            groupBoxPlanPago.Controls.Add(comboBoxQuincena);
            groupBoxPlanPago.Controls.Add(label17);
            groupBoxPlanPago.Controls.Add(BtnCrearPlan);
            groupBoxPlanPago.Controls.Add(textBoxMontoCuota);
            groupBoxPlanPago.Controls.Add(label16);
            groupBoxPlanPago.Controls.Add(textBoxDebe);
            groupBoxPlanPago.Controls.Add(label15);
            groupBoxPlanPago.Controls.Add(label14);
            groupBoxPlanPago.Controls.Add(comboBoxCantCuotas);
            groupBoxPlanPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBoxPlanPago.Location = new Point(12, 23);
            groupBoxPlanPago.Name = "groupBoxPlanPago";
            groupBoxPlanPago.Size = new Size(486, 171);
            groupBoxPlanPago.TabIndex = 79;
            groupBoxPlanPago.TabStop = false;
            groupBoxPlanPago.Text = "PLAN DE PAGO:";
            // 
            // comboBoxAnio
            // 
            comboBoxAnio.BackColor = SystemColors.Info;
            comboBoxAnio.FormattingEnabled = true;
            comboBoxAnio.Items.AddRange(new object[] { "2026", "2027", "2028", "2029", "2030", "2031", "2032", "2033", "2034", "2035", "2036" });
            comboBoxAnio.Location = new Point(250, 95);
            comboBoxAnio.Name = "comboBoxAnio";
            comboBoxAnio.Size = new Size(58, 23);
            comboBoxAnio.TabIndex = 11;
            // 
            // comboBoxMes
            // 
            comboBoxMes.BackColor = SystemColors.Info;
            comboBoxMes.FormattingEnabled = true;
            comboBoxMes.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxMes.Location = new Point(186, 95);
            comboBoxMes.Name = "comboBoxMes";
            comboBoxMes.Size = new Size(58, 23);
            comboBoxMes.TabIndex = 10;
            // 
            // comboBoxQuincena
            // 
            comboBoxQuincena.BackColor = SystemColors.Info;
            comboBoxQuincena.FormattingEnabled = true;
            comboBoxQuincena.Items.AddRange(new object[] { "1", "2" });
            comboBoxQuincena.Location = new Point(122, 95);
            comboBoxQuincena.Name = "comboBoxQuincena";
            comboBoxQuincena.Size = new Size(58, 23);
            comboBoxQuincena.TabIndex = 9;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(6, 99);
            label17.Name = "label17";
            label17.Size = new Size(113, 15);
            label17.TabIndex = 8;
            label17.Text = "quincena de gracia:";
            // 
            // BtnCrearPlan
            // 
            BtnCrearPlan.BackColor = Color.Gold;
            BtnCrearPlan.Location = new Point(324, 126);
            BtnCrearPlan.Name = "BtnCrearPlan";
            BtnCrearPlan.Size = new Size(141, 33);
            BtnCrearPlan.TabIndex = 7;
            BtnCrearPlan.Text = "CARGAR PLAN";
            BtnCrearPlan.UseVisualStyleBackColor = false;
            BtnCrearPlan.Click += BtnCrearPlan_Click;
            // 
            // textBoxMontoCuota
            // 
            textBoxMontoCuota.BackColor = SystemColors.Info;
            textBoxMontoCuota.Location = new Point(314, 66);
            textBoxMontoCuota.Name = "textBoxMontoCuota";
            textBoxMontoCuota.ReadOnly = true;
            textBoxMontoCuota.Size = new Size(79, 23);
            textBoxMontoCuota.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(229, 70);
            label16.Name = "label16";
            label16.Size = new Size(81, 15);
            label16.TabIndex = 4;
            label16.Text = "monto cuota:";
            // 
            // textBoxDebe
            // 
            textBoxDebe.BackColor = SystemColors.Info;
            textBoxDebe.Location = new Point(122, 37);
            textBoxDebe.Name = "textBoxDebe";
            textBoxDebe.ReadOnly = true;
            textBoxDebe.Size = new Size(271, 23);
            textBoxDebe.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(79, 41);
            label15.Name = "label15";
            label15.Size = new Size(40, 15);
            label15.TabIndex = 2;
            label15.Text = "Debe:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(42, 70);
            label14.Name = "label14";
            label14.Size = new Size(76, 15);
            label14.TabIndex = 1;
            label14.Text = "cant. cuotas:";
            // 
            // comboBoxCantCuotas
            // 
            comboBoxCantCuotas.BackColor = SystemColors.Info;
            comboBoxCantCuotas.FormattingEnabled = true;
            comboBoxCantCuotas.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            comboBoxCantCuotas.Location = new Point(122, 66);
            comboBoxCantCuotas.Name = "comboBoxCantCuotas";
            comboBoxCantCuotas.Size = new Size(84, 23);
            comboBoxCantCuotas.TabIndex = 0;
            comboBoxCantCuotas.SelectedValueChanged += ComboBoxCantCuotas_SelectedValueChanged;
            // 
            // CrearPlanDePagoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 214);
            Controls.Add(groupBoxPlanPago);
            Name = "CrearPlanDePagoForm";
            Text = "CrearPlanDePagoForm";
            groupBoxPlanPago.ResumeLayout(false);
            groupBoxPlanPago.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxPlanPago;
        private ComboBox comboBoxAnio;
        private ComboBox comboBoxMes;
        private ComboBox comboBoxQuincena;
        private Label label17;
        private Button BtnCrearPlan;
        private TextBox textBoxMontoCuota;
        private Label label16;
        private TextBox textBoxDebe;
        private Label label15;
        private Label label14;
        private ComboBox comboBoxCantCuotas;
    }
}