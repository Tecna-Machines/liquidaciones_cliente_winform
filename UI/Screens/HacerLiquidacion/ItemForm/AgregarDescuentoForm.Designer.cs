namespace UI.Screens.HacerLiquidacion.ItemForm
{
    partial class AgregarDescuentoForm
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
            labeTitulo = new Label();
            textBoxMonto = new TextBox();
            labelMonto = new Label();
            textBoxDescripcion = new TextBox();
            labelDesc = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // labeTitulo
            // 
            labeTitulo.AutoSize = true;
            labeTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labeTitulo.Location = new Point(60, 9);
            labeTitulo.Name = "labeTitulo";
            labeTitulo.Size = new Size(332, 19);
            labeTitulo.TabIndex = 12;
            labeTitulo.Text = "AGREGAR UN DESCUENTO A ESTA LIQUIDACION:";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(114, 93);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(349, 23);
            textBoxMonto.TabIndex = 11;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.Location = new Point(21, 93);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(73, 15);
            labelMonto.TabIndex = 10;
            labelMonto.Text = "MONTO: ($)";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(114, 51);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(349, 23);
            textBoxDescripcion.TabIndex = 9;
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDesc.Location = new Point(21, 54);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(87, 15);
            labelDesc.TabIndex = 8;
            labelDesc.Text = "DESCRIPCION:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(180, 130);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(148, 49);
            btnConfirmar.TabIndex = 13;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // AgregarDescuentoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 191);
            Controls.Add(btnConfirmar);
            Controls.Add(labeTitulo);
            Controls.Add(textBoxMonto);
            Controls.Add(labelMonto);
            Controls.Add(textBoxDescripcion);
            Controls.Add(labelDesc);
            Name = "AgregarDescuentoForm";
            Text = "AgregarDescuentoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labeTitulo;
        private TextBox textBoxMonto;
        private Label labelMonto;
        private TextBox textBoxDescripcion;
        private Label labelDesc;
        private Button btnConfirmar;
    }
}