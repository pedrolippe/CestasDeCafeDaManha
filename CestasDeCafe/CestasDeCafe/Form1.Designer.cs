namespace CestasDeCafe
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnBronze = new Button();
            btnPrata = new Button();
            btnOuro = new Button();
            btnPersonalizar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Bodoni MT", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-1, 0);
            label1.Name = "label1";
            label1.Size = new Size(1052, 142);
            label1.TabIndex = 0;
            label1.Text = "Cestas de Café";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnBronze
            // 
            btnBronze.BackColor = Color.DarkGray;
            btnBronze.Font = new Font("Bodoni MT Condensed", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBronze.Location = new Point(12, 185);
            btnBronze.Name = "btnBronze";
            btnBronze.Size = new Size(250, 250);
            btnBronze.TabIndex = 1;
            btnBronze.Text = "Cesta Bronze";
            btnBronze.UseVisualStyleBackColor = false;
            btnBronze.Click += btnBronze_Click;
            // 
            // btnPrata
            // 
            btnPrata.BackColor = Color.DarkGray;
            btnPrata.Font = new Font("Bodoni MT Condensed", 25.8000011F);
            btnPrata.Location = new Point(268, 185);
            btnPrata.Name = "btnPrata";
            btnPrata.Size = new Size(250, 250);
            btnPrata.TabIndex = 2;
            btnPrata.Text = "Cesta Prata";
            btnPrata.UseVisualStyleBackColor = false;
            btnPrata.Click += btnPrata_Click;
            // 
            // btnOuro
            // 
            btnOuro.BackColor = Color.DarkGray;
            btnOuro.Font = new Font("Bodoni MT Condensed", 25.8000011F);
            btnOuro.Location = new Point(529, 185);
            btnOuro.Name = "btnOuro";
            btnOuro.Size = new Size(250, 250);
            btnOuro.TabIndex = 3;
            btnOuro.Text = "Cesta Ouro";
            btnOuro.UseVisualStyleBackColor = false;
            btnOuro.Click += btnOuro_Click;
            // 
            // btnPersonalizar
            // 
            btnPersonalizar.BackColor = Color.DarkGray;
            btnPersonalizar.Font = new Font("Bodoni MT Condensed", 25.8000011F);
            btnPersonalizar.Location = new Point(785, 185);
            btnPersonalizar.Name = "btnPersonalizar";
            btnPersonalizar.Size = new Size(250, 250);
            btnPersonalizar.TabIndex = 4;
            btnPersonalizar.Text = "Cesta Personalizada";
            btnPersonalizar.UseVisualStyleBackColor = false;
            btnPersonalizar.Click += btnPersonalizar_Click;
            // 
            // label2
            // 
            label2.BackColor = Color.DimGray;
            label2.Font = new Font("Bodoni MT Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(-1, 688);
            label2.Name = "label2";
            label2.Size = new Size(1052, 23);
            label2.TabIndex = 5;
            label2.Text = "Pedro Henrique de Souza Lippe";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 711);
            Controls.Add(label2);
            Controls.Add(btnPersonalizar);
            Controls.Add(btnOuro);
            Controls.Add(btnPrata);
            Controls.Add(btnBronze);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPrincipal";
            Text = "Cestas de Café da Manhã";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnBronze;
        private Button btnPrata;
        private Button btnOuro;
        private Button btnPersonalizar;
        private Label label2;
    }
}
