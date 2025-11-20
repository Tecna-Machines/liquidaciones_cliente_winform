namespace UI.Screens.CrearContrato
{
    partial class CrearAdicionalForm
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
            textBoxDescripcion = new TextBox();
            labelDescripcion = new Label();
            textBoxMonto = new TextBox();
            labelMonto = new Label();
            checkBoxEsEnBlanco = new CheckBox();
            checkBoxEsPorcentual = new CheckBox();
            label1 = new Label();
            BtnAgregar = new Button();
            SuspendLayout();
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(117, 49);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(335, 23);
            textBoxDescripcion.TabIndex = 0;
            // 
            // labelDescripcion
            // 
            labelDescripcion.AutoSize = true;
            labelDescripcion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDescripcion.Location = new Point(19, 52);
            labelDescripcion.Name = "labelDescripcion";
            labelDescripcion.Size = new Size(87, 15);
            labelDescripcion.TabIndex = 1;
            labelDescripcion.Text = "DESCRIPCION:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(117, 89);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(197, 23);
            textBoxMonto.TabIndex = 2;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.Location = new Point(51, 97);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(55, 15);
            labelMonto.TabIndex = 3;
            labelMonto.Text = "MONTO:";
            // 
            // checkBoxEsEnBlanco
            // 
            checkBoxEsEnBlanco.AutoSize = true;
            checkBoxEsEnBlanco.Location = new Point(117, 127);
            checkBoxEsEnBlanco.Name = "checkBoxEsEnBlanco";
            checkBoxEsEnBlanco.Size = new Size(114, 19);
            checkBoxEsEnBlanco.TabIndex = 6;
            checkBoxEsEnBlanco.Text = "ES EN BLANCO ?";
            checkBoxEsEnBlanco.UseVisualStyleBackColor = true;
            // 
            // checkBoxEsPorcentual
            // 
            checkBoxEsPorcentual.AutoSize = true;
            checkBoxEsPorcentual.Location = new Point(117, 152);
            checkBoxEsPorcentual.Name = "checkBoxEsPorcentual";
            checkBoxEsPorcentual.Size = new Size(123, 19);
            checkBoxEsPorcentual.TabIndex = 7;
            checkBoxEsPorcentual.Text = "ES PORCENTUAL ?";
            checkBoxEsPorcentual.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(19, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 21);
            label1.TabIndex = 8;
            label1.Text = "AGREGAR ADICIONAL :";
            // 
            // BtnAgregar
            // 
            BtnAgregar.BackColor = SystemColors.ActiveCaption;
            BtnAgregar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAgregar.Location = new Point(117, 195);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(164, 38);
            BtnAgregar.TabIndex = 9;
            BtnAgregar.Text = "AGREGAR";
            BtnAgregar.UseVisualStyleBackColor = false;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // CrearAdicionalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(471, 245);
            Controls.Add(BtnAgregar);
            Controls.Add(label1);
            Controls.Add(checkBoxEsPorcentual);
            Controls.Add(checkBoxEsEnBlanco);
            Controls.Add(labelMonto);
            Controls.Add(textBoxMonto);
            Controls.Add(labelDescripcion);
            Controls.Add(textBoxDescripcion);
            Name = "CrearAdicionalForm";
            Text = "CrearAdicional";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDescripcion;
        private Label labelDescripcion;
        private TextBox textBoxMonto;
        private Label labelMonto;
        private CheckBox checkBoxEsEnBlanco;
        private CheckBox checkBoxEsPorcentual;
        private Label label1;
        private Button BtnAgregar;
    }
}