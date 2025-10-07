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
            label1 = new Label();
            lstProdutos = new ListBox();
            btnCafe = new Button();
            btnCapuccinno = new Button();
            btnCha = new Button();
            btnTorrada = new Button();
            btnBolacha = new Button();
            btnCookies = new Button();
            btnGeleia = new Button();
            btnNutella = new Button();
            btnUvas = new Button();
            btnRosas = new Button();
            lblValor = new Label();
            label2 = new Label();
            btnPagamento = new Button();
            btnExcluir = new Button();
            SuspendLayout();
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
            // lstProdutos
            // 
            lstProdutos.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.Location = new Point(529, 145);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.SelectionMode = SelectionMode.MultiSimple;
            lstProdutos.Size = new Size(506, 521);
            lstProdutos.TabIndex = 28;
            lstProdutos.SelectedIndexChanged += lstProdutos_SelectedIndexChanged;
            // 
            // btnCafe
            // 
            btnCafe.BackColor = Color.DarkGray;
            btnCafe.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCafe.Location = new Point(12, 145);
            btnCafe.Name = "btnCafe";
            btnCafe.Size = new Size(95, 95);
            btnCafe.TabIndex = 29;
            btnCafe.Text = "Café Solúvel";
            btnCafe.UseVisualStyleBackColor = false;
            btnCafe.Click += btnCafe_Click;
            // 
            // btnCapuccinno
            // 
            btnCapuccinno.BackColor = Color.DarkGray;
            btnCapuccinno.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCapuccinno.Location = new Point(113, 145);
            btnCapuccinno.Name = "btnCapuccinno";
            btnCapuccinno.Size = new Size(95, 95);
            btnCapuccinno.TabIndex = 30;
            btnCapuccinno.Text = "Cappuccino";
            btnCapuccinno.UseVisualStyleBackColor = false;
            btnCapuccinno.Click += btnCapuccinno_Click;
            // 
            // btnCha
            // 
            btnCha.BackColor = Color.DarkGray;
            btnCha.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCha.Location = new Point(214, 145);
            btnCha.Name = "btnCha";
            btnCha.Size = new Size(95, 95);
            btnCha.TabIndex = 31;
            btnCha.Text = "Chá";
            btnCha.UseVisualStyleBackColor = false;
            btnCha.Click += btnCha_Click;
            // 
            // btnTorrada
            // 
            btnTorrada.BackColor = Color.DarkGray;
            btnTorrada.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTorrada.Location = new Point(315, 145);
            btnTorrada.Name = "btnTorrada";
            btnTorrada.Size = new Size(95, 95);
            btnTorrada.TabIndex = 32;
            btnTorrada.Text = "Torrada";
            btnTorrada.UseVisualStyleBackColor = false;
            btnTorrada.Click += btnTorrada_Click;
            // 
            // btnBolacha
            // 
            btnBolacha.BackColor = Color.DarkGray;
            btnBolacha.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBolacha.Location = new Point(416, 145);
            btnBolacha.Name = "btnBolacha";
            btnBolacha.Size = new Size(95, 95);
            btnBolacha.TabIndex = 33;
            btnBolacha.Text = "Bolacha Champanhe";
            btnBolacha.UseVisualStyleBackColor = false;
            btnBolacha.Click += btnBolacha_Click;
            // 
            // btnCookies
            // 
            btnCookies.BackColor = Color.DarkGray;
            btnCookies.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCookies.Location = new Point(12, 246);
            btnCookies.Name = "btnCookies";
            btnCookies.Size = new Size(95, 95);
            btnCookies.TabIndex = 34;
            btnCookies.Text = "Cookies";
            btnCookies.UseVisualStyleBackColor = false;
            btnCookies.Click += btnCookies_Click;
            // 
            // btnGeleia
            // 
            btnGeleia.BackColor = Color.DarkGray;
            btnGeleia.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGeleia.Location = new Point(113, 246);
            btnGeleia.Name = "btnGeleia";
            btnGeleia.Size = new Size(95, 95);
            btnGeleia.TabIndex = 35;
            btnGeleia.Text = "Geleia";
            btnGeleia.UseVisualStyleBackColor = false;
            btnGeleia.Click += btnGeleia_Click;
            // 
            // btnNutella
            // 
            btnNutella.BackColor = Color.DarkGray;
            btnNutella.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNutella.Location = new Point(214, 246);
            btnNutella.Name = "btnNutella";
            btnNutella.Size = new Size(95, 95);
            btnNutella.TabIndex = 36;
            btnNutella.Text = "Nutella";
            btnNutella.UseVisualStyleBackColor = false;
            btnNutella.Click += btnNutella_Click;
            // 
            // btnUvas
            // 
            btnUvas.BackColor = Color.DarkGray;
            btnUvas.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUvas.Location = new Point(315, 246);
            btnUvas.Name = "btnUvas";
            btnUvas.Size = new Size(95, 95);
            btnUvas.TabIndex = 37;
            btnUvas.Text = "Uvas";
            btnUvas.UseVisualStyleBackColor = false;
            btnUvas.Click += btnUvas_Click;
            // 
            // btnRosas
            // 
            btnRosas.BackColor = Color.DarkGray;
            btnRosas.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRosas.Location = new Point(416, 246);
            btnRosas.Name = "btnRosas";
            btnRosas.Size = new Size(95, 95);
            btnRosas.TabIndex = 38;
            btnRosas.Text = "Buquê de Rosas";
            btnRosas.UseVisualStyleBackColor = false;
            btnRosas.Click += btnRosas_Click;
            // 
            // lblValor
            // 
            lblValor.BackColor = SystemColors.Window;
            lblValor.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(12, 406);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(499, 55);
            lblValor.TabIndex = 40;
            lblValor.Click += lblValor_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 361);
            label2.Name = "label2";
            label2.Size = new Size(125, 45);
            label2.TabIndex = 39;
            label2.Text = "Valor:";
            // 
            // btnPagamento
            // 
            btnPagamento.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnPagamento.BackColor = Color.DarkGray;
            btnPagamento.Font = new Font("Bodoni MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPagamento.Location = new Point(12, 493);
            btnPagamento.Name = "btnPagamento";
            btnPagamento.Size = new Size(245, 173);
            btnPagamento.TabIndex = 41;
            btnPagamento.Text = "PAGAMENTO";
            btnPagamento.UseVisualStyleBackColor = false;
            btnPagamento.Click += btnPagamento_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.BackColor = Color.DarkGray;
            btnExcluir.Font = new Font("Bodoni MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnExcluir.Location = new Point(266, 493);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(245, 173);
            btnExcluir.TabIndex = 42;
            btnExcluir.Text = "EXCLUIR";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // frmPersonalizado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(1047, 711);
            Controls.Add(btnExcluir);
            Controls.Add(btnPagamento);
            Controls.Add(lblValor);
            Controls.Add(label2);
            Controls.Add(btnRosas);
            Controls.Add(btnUvas);
            Controls.Add(btnNutella);
            Controls.Add(btnGeleia);
            Controls.Add(btnCookies);
            Controls.Add(btnBolacha);
            Controls.Add(btnTorrada);
            Controls.Add(btnCha);
            Controls.Add(btnCapuccinno);
            Controls.Add(btnCafe);
            Controls.Add(lstProdutos);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPersonalizado";
            Text = "v";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private ListBox lstProdutos;
        private Button btnCafe;
        private Button btnCapuccinno;
        private Button btnCha;
        private Button btnTorrada;
        private Button btnBolacha;
        private Button btnCookies;
        private Button btnGeleia;
        private Button btnNutella;
        private Button btnUvas;
        private Button btnRosas;
        private Label lblValor;
        private Label label2;
        private Button btnPagamento;
        private Button btnExcluir;
    }
}