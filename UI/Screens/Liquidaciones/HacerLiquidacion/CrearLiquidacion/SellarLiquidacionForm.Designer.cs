namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    partial class SellarLiquidacionForm
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
            label1 = new Label();
            label2 = new Label();
            BtnOk = new Button();
            BtnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(155, 9);
            label1.Name = "label1";
            label1.Size = new Size(163, 28);
            label1.TabIndex = 0;
            label1.Text = "¡ADVERTENCIA!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(76, 70);
            label2.Name = "label2";
            label2.Size = new Size(334, 20);
            label2.TabIndex = 1;
            label2.Text = "esta liquidacion no se podra volver a modificar\r\n";
            // 
            // BtnOk
            // 
            BtnOk.BackColor = Color.Moccasin;
            BtnOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnOk.Location = new Point(113, 102);
            BtnOk.Name = "BtnOk";
            BtnOk.Size = new Size(109, 40);
            BtnOk.TabIndex = 2;
            BtnOk.Text = "confirmar";
            BtnOk.UseVisualStyleBackColor = false;
            BtnOk.Click += BtnOk_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(228, 102);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(109, 40);
            BtnCancelar.TabIndex = 3;
            BtnCancelar.Text = "cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // SellarLiquidacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 171);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnOk);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SellarLiquidacionForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "SellarLiquidacionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnOk;
        private Button BtnCancelar;
    }
}