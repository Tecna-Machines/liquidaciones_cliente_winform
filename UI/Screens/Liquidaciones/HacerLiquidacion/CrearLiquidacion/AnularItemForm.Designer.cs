namespace UI.Screens.Liquidaciones.HacerLiquidacion.CrearLiquidacion
{
    partial class AnularItemForm
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
            textBoxConcepto = new TextBox();
            textBoxMonto = new TextBox();
            textBoxFecha = new TextBox();
            BtnAnular = new Button();
            BtnCancelar = new Button();
            textBoxEsAutomatico = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxConcepto
            // 
            textBoxConcepto.BackColor = SystemColors.Info;
            textBoxConcepto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxConcepto.Location = new Point(88, 15);
            textBoxConcepto.Name = "textBoxConcepto";
            textBoxConcepto.ReadOnly = true;
            textBoxConcepto.Size = new Size(360, 25);
            textBoxConcepto.TabIndex = 0;
            // 
            // textBoxMonto
            // 
            textBoxMonto.BackColor = SystemColors.Info;
            textBoxMonto.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxMonto.Location = new Point(88, 64);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.ReadOnly = true;
            textBoxMonto.Size = new Size(360, 25);
            textBoxMonto.TabIndex = 1;
            // 
            // textBoxFecha
            // 
            textBoxFecha.BackColor = SystemColors.Info;
            textBoxFecha.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxFecha.Location = new Point(88, 107);
            textBoxFecha.Name = "textBoxFecha";
            textBoxFecha.ReadOnly = true;
            textBoxFecha.Size = new Size(360, 25);
            textBoxFecha.TabIndex = 2;
            // 
            // BtnAnular
            // 
            BtnAnular.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnAnular.Location = new Point(88, 196);
            BtnAnular.Name = "BtnAnular";
            BtnAnular.Size = new Size(127, 49);
            BtnAnular.TabIndex = 3;
            BtnAnular.Text = "BORRAR";
            BtnAnular.UseVisualStyleBackColor = true;
            BtnAnular.Click += BtnAnular_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.BackColor = Color.IndianRed;
            BtnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancelar.Location = new Point(282, 196);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(127, 49);
            BtnCancelar.TabIndex = 4;
            BtnCancelar.Text = "CANCELAR";
            BtnCancelar.UseVisualStyleBackColor = false;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // textBoxEsAutomatico
            // 
            textBoxEsAutomatico.BackColor = SystemColors.Info;
            textBoxEsAutomatico.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxEsAutomatico.Location = new Point(88, 152);
            textBoxEsAutomatico.Name = "textBoxEsAutomatico";
            textBoxEsAutomatico.ReadOnly = true;
            textBoxEsAutomatico.Size = new Size(360, 25);
            textBoxEsAutomatico.TabIndex = 5;
            textBoxEsAutomatico.Text = "este item puede anularse";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(77, 19);
            label1.TabIndex = 6;
            label1.Text = "Concepto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 7;
            label2.Text = "Monto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 110);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 8;
            label3.Text = "Fecha:";
            // 
            // AnularItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 268);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxEsAutomatico);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnAnular);
            Controls.Add(textBoxFecha);
            Controls.Add(textBoxMonto);
            Controls.Add(textBoxConcepto);
            Name = "AnularItemForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AnularItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxConcepto;
        private TextBox textBoxMonto;
        private TextBox textBoxFecha;
        private Button BtnAnular;
        private Button BtnCancelar;
        private TextBox textBoxEsAutomatico;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}