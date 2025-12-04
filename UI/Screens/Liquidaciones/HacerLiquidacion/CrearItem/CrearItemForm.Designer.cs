namespace UI.Screens.HacerLiquidacion
{
    partial class CrearItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearItemForm));
            labelAgre = new Label();
            textBoxConcepto = new TextBox();
            comboBoxTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            BtnAgregar = new Button();
            textBoxMonto = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // labelAgre
            // 
            labelAgre.AutoSize = true;
            labelAgre.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelAgre.Location = new Point(23, 31);
            labelAgre.Name = "labelAgre";
            labelAgre.Size = new Size(93, 21);
            labelAgre.TabIndex = 3;
            labelAgre.Text = "Crear item:";
            // 
            // textBoxConcepto
            // 
            textBoxConcepto.Location = new Point(141, 70);
            textBoxConcepto.Name = "textBoxConcepto";
            textBoxConcepto.Size = new Size(277, 23);
            textBoxConcepto.TabIndex = 0;
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "Remunerativo (en blanco)", "Remunerativo (en negro)", "No Remunerativo (en blanco)", "Descuento (en negro)" });
            comboBoxTipo.Location = new Point(141, 134);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(277, 23);
            comboBoxTipo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(48, 72);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 6;
            label1.Text = "Concepto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(82, 136);
            label2.Name = "label2";
            label2.Size = new Size(43, 19);
            label2.TabIndex = 7;
            label2.Text = "Tipo:";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = Color.LightSalmon;
            BtnAgregar.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.ForeColor = SystemColors.ActiveCaptionText;
            BtnAgregar.Location = new Point(302, 180);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(116, 51);
            BtnAgregar.TabIndex = 4;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(141, 101);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(277, 23);
            textBoxMonto.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 103);
            label3.Name = "label3";
            label3.Size = new Size(57, 19);
            label3.TabIndex = 10;
            label3.Text = "Monto:";
            // 
            // CrearItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 243);
            Controls.Add(label3);
            Controls.Add(textBoxMonto);
            Controls.Add(BtnAgregar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxTipo);
            Controls.Add(textBoxConcepto);
            Controls.Add(labelAgre);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CrearItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CrearItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelAgre;
        private TextBox textBoxConcepto;
        private ComboBox comboBoxTipo;
        private Label label1;
        private Label label2;
        private Button BtnAgregar;
        private TextBox textBoxMonto;
        private Label label3;
    }
}