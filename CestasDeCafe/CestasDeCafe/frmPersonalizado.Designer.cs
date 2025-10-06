namespace CestasDeCafe
{
    partial class frmPersonalizado
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
            lstProdutos = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(528, 145);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(506, 424);
            lstProdutos.TabIndex = 28;
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Bodoni MT", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1052, 142);
            label1.TabIndex = 27;
            label1.Text = "Cesta Personalizada";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmPersonalizado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 711);
            Controls.Add(lstProdutos);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPersonalizado";
            Text = "Cesta Personalizada";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstProdutos;
        private Label label1;
    }
}