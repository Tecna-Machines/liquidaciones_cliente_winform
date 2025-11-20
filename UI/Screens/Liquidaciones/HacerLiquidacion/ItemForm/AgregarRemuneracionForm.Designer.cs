namespace UI.Screens.HacerLiquidacion.ItemForm
{
    partial class AgregarRemuneracionForm
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
            labelDesc = new Label();
            textBoxDescripcion = new TextBox();
            labelMonto = new Label();
            textBoxMonto = new TextBox();
            labelPregunta = new Label();
            btnRespuesta_si = new Button();
            btnRespuesta_no = new Button();
            labeTitulo = new Label();
            btnConfirmar = new Button();
            SuspendLayout();
            // 
            // labelDesc
            // 
            labelDesc.AutoSize = true;
            labelDesc.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelDesc.Location = new Point(18, 68);
            labelDesc.Name = "labelDesc";
            labelDesc.Size = new Size(87, 15);
            labelDesc.TabIndex = 0;
            labelDesc.Text = "DESCRIPCION:";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Location = new Point(111, 65);
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.Size = new Size(349, 23);
            textBoxDescripcion.TabIndex = 1;
            // 
            // labelMonto
            // 
            labelMonto.AutoSize = true;
            labelMonto.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMonto.Location = new Point(18, 107);
            labelMonto.Name = "labelMonto";
            labelMonto.Size = new Size(73, 15);
            labelMonto.TabIndex = 2;
            labelMonto.Text = "MONTO: ($)";
            // 
            // textBoxMonto
            // 
            textBoxMonto.Location = new Point(111, 107);
            textBoxMonto.Name = "textBoxMonto";
            textBoxMonto.Size = new Size(349, 23);
            textBoxMonto.TabIndex = 3;
            textBoxMonto.KeyPress += textBoxMonto_KeyPress;
            // 
            // labelPregunta
            // 
            labelPregunta.AutoSize = true;
            labelPregunta.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPregunta.Location = new Point(18, 154);
            labelPregunta.Name = "labelPregunta";
            labelPregunta.Size = new Size(187, 15);
            labelPregunta.TabIndex = 4;
            labelPregunta.Text = "esta remuneracion es en blanco?";
            // 
            // btnRespuesta_si
            // 
            btnRespuesta_si.Location = new Point(220, 154);
            btnRespuesta_si.Name = "btnRespuesta_si";
            btnRespuesta_si.Size = new Size(75, 23);
            btnRespuesta_si.TabIndex = 5;
            btnRespuesta_si.Text = "SI";
            btnRespuesta_si.UseVisualStyleBackColor = true;
            btnRespuesta_si.Click += btnRespuesta_si_Click;
            // 
            // btnRespuesta_no
            // 
            btnRespuesta_no.Location = new Point(320, 154);
            btnRespuesta_no.Name = "btnRespuesta_no";
            btnRespuesta_no.Size = new Size(75, 23);
            btnRespuesta_no.TabIndex = 6;
            btnRespuesta_no.Text = "NO";
            btnRespuesta_no.UseVisualStyleBackColor = true;
            btnRespuesta_no.Click += btnRespuesta_no_Click;
            // 
            // labeTitulo
            // 
            labeTitulo.AutoSize = true;
            labeTitulo.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labeTitulo.Location = new Point(57, 23);
            labeTitulo.Name = "labeTitulo";
            labeTitulo.Size = new Size(338, 19);
            labeTitulo.TabIndex = 7;
            labeTitulo.Text = "AGREGAR REMUNERACION A ESTA LIQUIDACION:";
            // 
            // btnConfirmar
            // 
            btnConfirmar.BackColor = SystemColors.ActiveCaption;
            btnConfirmar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfirmar.Location = new Point(18, 187);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(148, 49);
            btnConfirmar.TabIndex = 8;
            btnConfirmar.Text = "CONFIRMAR";
            btnConfirmar.UseVisualStyleBackColor = false;
            btnConfirmar.Click += btnConfirmar_Click;
            // 
            // AgregarRemuneracionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 248);
            Controls.Add(btnConfirmar);
            Controls.Add(labeTitulo);
            Controls.Add(btnRespuesta_no);
            Controls.Add(btnRespuesta_si);
            Controls.Add(labelPregunta);
            Controls.Add(textBoxMonto);
            Controls.Add(labelMonto);
            Controls.Add(textBoxDescripcion);
            Controls.Add(labelDesc);
            Name = "AgregarRemuneracionForm";
            Text = "AgregarRemuneracionForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelDesc;
        private TextBox textBoxDescripcion;
        private Label labelMonto;
        private TextBox textBoxMonto;
        private Label labelPregunta;
        private Button btnRespuesta_si;
        private Button btnRespuesta_no;
        private Label labeTitulo;
        private Button btnConfirmar;
    }
}