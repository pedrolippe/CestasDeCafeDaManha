namespace CestasDeCafe
{
    partial class frmOuro
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
            lblValor = new Label();
            numQuantidade = new NumericUpDown();
            label3 = new Label();
            btnPagamento = new Button();
            label2 = new Label();
            lstProdutos = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.DimGray;
            label1.Font = new Font("Bodoni MT", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(-3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1052, 142);
            label1.TabIndex = 25;
            label1.Text = "Cesta Ouro";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblValor
            // 
            lblValor.BackColor = SystemColors.Window;
            lblValor.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(12, 296);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(502, 55);
            lblValor.TabIndex = 35;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Bodoni MT", 24F);
            numQuantidade.Location = new Point(12, 193);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(502, 55);
            numQuantidade.TabIndex = 34;
            numQuantidade.TextAlign = HorizontalAlignment.Center;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(229, 45);
            label3.TabIndex = 33;
            label3.Text = "Quantidade:";
            // 
            // btnPagamento
            // 
            btnPagamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPagamento.BackColor = Color.DarkGray;
            btnPagamento.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagamento.Location = new Point(12, 527);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(502, 173);
            btnPagamento.TabIndex = 32;
            btnPagamento.Text = "PAGAMENTO";
            btnPagamento.UseVisualStyleBackColor = false;
            btnPagamento.Click += btnPagamento_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 251);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 31;
            label2.Text = "Valor:";
            // 
            // lstProdutos
            // 
            lstProdutos.Font = new Font("Bodoni MT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Items.AddRange(new object[] { "Café Solúvel", "Cappuccino", "Chá", "Torrada", "Bolacha Champanhe", "Cookies", "Geleia", "Nutella", "Uvas", "Buquê de Rosas" });
            lstProdutos.Location = new Point(529, 145);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(506, 564);
            lstProdutos.TabIndex = 30;
            // 
            // frmOuro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 711);
            Controls.Add(lblValor);
            Controls.Add(numQuantidade);
            Controls.Add(label3);
            Controls.Add(btnPagamento);
            Controls.Add(label2);
            Controls.Add(lstProdutos);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmOuro";
            Text = "Cesta Ouro";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label lblValor;
        private NumericUpDown numQuantidade;
        private Label label3;
        private Button btnPagamento;
        private Label label2;
        private ListBox lstProdutos;
    }
}