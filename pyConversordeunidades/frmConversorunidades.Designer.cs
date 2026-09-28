namespace pyConversordeunidades
{
    partial class frmConversorunidades
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
            lblValor = new Label();
            lblHasta = new Label();
            lblResultado = new Label();
            cmbDesde = new ComboBox();
            cmbHasta = new ComboBox();
            btnResultado = new Button();
            txtValor = new TextBox();
            lblDesde = new Label();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(36, 40);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(33, 15);
            lblValor.TabIndex = 0;
            lblValor.Text = "Valor";
            lblValor.Click += label1_Click;
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(36, 105);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 2;
            lblHasta.Text = "Hasta:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(36, 219);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 15);
            lblResultado.TabIndex = 3;
            // 
            // cmbDesde
            // 
            cmbDesde.FormattingEnabled = true;
            cmbDesde.Items.AddRange(new object[] { "Centimetros", "Metros" });
            cmbDesde.Location = new Point(122, 72);
            cmbDesde.Name = "cmbDesde";
            cmbDesde.Size = new Size(149, 23);
            cmbDesde.TabIndex = 4;
            // 
            // cmbHasta
            // 
            cmbHasta.FormattingEnabled = true;
            cmbHasta.Items.AddRange(new object[] { "Centimetros", "Metros" });
            cmbHasta.Location = new Point(122, 105);
            cmbHasta.Name = "cmbHasta";
            cmbHasta.Size = new Size(149, 23);
            cmbHasta.TabIndex = 5;
            // 
            // btnResultado
            // 
            btnResultado.Location = new Point(140, 174);
            btnResultado.Name = "btnResultado";
            btnResultado.Size = new Size(103, 27);
            btnResultado.TabIndex = 6;
            btnResultado.Text = "Resultado";
            btnResultado.UseVisualStyleBackColor = true;
            btnResultado.Click += btnResultado_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(120, 32);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(164, 23);
            txtValor.TabIndex = 7;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(36, 70);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde:";
            lblDesde.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmConversorunidades
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 277);
            Controls.Add(txtValor);
            Controls.Add(btnResultado);
            Controls.Add(cmbHasta);
            Controls.Add(cmbDesde);
            Controls.Add(lblResultado);
            Controls.Add(lblHasta);
            Controls.Add(lblDesde);
            Controls.Add(lblValor);
            Name = "frmConversorunidades";
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private Label label2;
        private Label lblHasta;
        private Label lblResultado;
        private ComboBox cmbDesde;
        private ComboBox cmbHasta;
        private Button btnResultado;
        private TextBox txtValor;
        private Label lblDesde;
    }
}