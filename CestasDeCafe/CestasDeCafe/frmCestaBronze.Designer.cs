namespace CestasDeCafe
{
    partial class frmCestaBronze
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
            lstProdutos = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Bodoni MT", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(1052, 142);
            label1.TabIndex = 1;
            label1.Text = "Cesta Bronze";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lstProdutos
            // 
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(529, 144);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(506, 424);
            lstProdutos.TabIndex = 22;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // frmCestaBronze
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 711);
            Controls.Add(lstProdutos);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmCestaBronze";
            Text = "Cesta Bronze";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox lstProdutos;
    }
}