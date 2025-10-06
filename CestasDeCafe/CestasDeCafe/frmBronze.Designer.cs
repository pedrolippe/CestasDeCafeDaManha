namespace CestasDeCafe
{
    partial class frmBronze
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
            label2 = new Label();
            btnPagamento = new Button();
            label3 = new Label();
            numQuantidade = new NumericUpDown();
            lblValor = new Label();
            ((System.ComponentModel.ISupportInitialize)numQuantidade).BeginInit();
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
            lstProdutos.Font = new Font("Bodoni MT", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Items.AddRange(new object[] { "Café Solúvel", "Torrada", "Geleia", "Uvas", "Cookies" });
            lstProdutos.Location = new Point(529, 144);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(506, 564);
            lstProdutos.TabIndex = 22;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(128, 45);
            label2.TabIndex = 23;
            label2.Text = "Valor:";
            // 
            // btnPagamento
            // 
            btnPagamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPagamento.BackColor = Color.DarkGray;
            btnPagamento.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagamento.Location = new Point(12, 526);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(502, 173);
            btnPagamento.TabIndex = 25;
            btnPagamento.Text = "PAGAMENTO";
            btnPagamento.UseVisualStyleBackColor = false;
            btnPagamento.Click += button1_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 144);
            label3.Name = "label3";
            label3.Size = new Size(229, 45);
            label3.TabIndex = 26;
            label3.Text = "Quantidade:";
            label3.Click += label3_Click;
            // 
            // numQuantidade
            // 
            numQuantidade.Font = new Font("Bodoni MT", 24F);
            numQuantidade.Location = new Point(12, 192);
            numQuantidade.Name = "numQuantidade";
            numQuantidade.Size = new Size(502, 55);
            numQuantidade.TabIndex = 28;
            numQuantidade.TextAlign = HorizontalAlignment.Center;
            numQuantidade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantidade.ValueChanged += numQuantidade_ValueChanged;
            // 
            // lblValor
            // 
            lblValor.BackColor = SystemColors.Window;
            lblValor.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(12, 295);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(502, 55);
            lblValor.TabIndex = 29;
            lblValor.Click += lblValor_Click;
            // 
            // frmBronze
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
            Name = "frmBronze";
            Text = "Cesta Bronze";
            ((System.ComponentModel.ISupportInitialize)numQuantidade).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ListBox lstProdutos;
        private Label label2;
        private Button btnPagamento;
        private Label label3;
        private NumericUpDown numQuantidade;
        private Label lblValor;
    }
}