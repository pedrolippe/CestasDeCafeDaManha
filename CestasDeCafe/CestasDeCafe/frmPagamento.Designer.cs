namespace CestasDeCafe
{
    partial class frmPagamento
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label3 = new Label();
            label6 = new Label();
            txtEmail = new TextBox();
            txtCelular = new TextBox();
            SuspendLayout();
            // 
            // lblValor
            // 
            lblValor.BackColor = SystemColors.Window;
            lblValor.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblValor.Location = new Point(12, 54);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(401, 55);
            lblValor.TabIndex = 31;
            lblValor.Click += lblValor_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(401, 45);
            label2.TabIndex = 30;
            label2.Text = "Valor Total:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 364);
            label1.Name = "label1";
            label1.Size = new Size(401, 54);
            label1.TabIndex = 32;
            label1.Text = "Formas de Pagamento";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Bodoni MT", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 421);
            button1.Name = "button1";
            button1.Size = new Size(95, 95);
            button1.TabIndex = 33;
            button1.Text = "Boleto";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Bodoni MT", 10.2F);
            button2.Location = new Point(113, 421);
            button2.Name = "button2";
            button2.Size = new Size(95, 95);
            button2.TabIndex = 34;
            button2.Text = "Pix";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Bodoni MT", 10.2F);
            button3.Location = new Point(217, 421);
            button3.Name = "button3";
            button3.Size = new Size(95, 95);
            button3.TabIndex = 35;
            button3.Text = "Cartão de Crédito";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Bodoni MT", 10.2F);
            button4.Location = new Point(318, 421);
            button4.Name = "button4";
            button4.Size = new Size(95, 95);
            button4.TabIndex = 36;
            button4.Text = "Cartão de Débito";
            button4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 121);
            label3.Name = "label3";
            label3.Size = new Size(401, 45);
            label3.TabIndex = 37;
            label3.Text = "Informe seu E-mail";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Bodoni MT", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 237);
            label6.Name = "label6";
            label6.Size = new Size(401, 45);
            label6.TabIndex = 39;
            label6.Text = "Informe seu Celular";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(12, 169);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(401, 43);
            txtEmail.TabIndex = 41;
            // 
            // txtCelular
            // 
            txtCelular.Font = new Font("Bodoni MT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCelular.Location = new Point(12, 285);
            txtCelular.Name = "txtCelular";
            txtCelular.Size = new Size(401, 43);
            txtCelular.TabIndex = 42;
            // 
            // frmPagamento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(425, 536);
            Controls.Add(txtCelular);
            Controls.Add(txtEmail);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(lblValor);
            Controls.Add(label2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmPagamento";
            Text = "frmPagamento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblValor;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label3;
        private Label label6;
        private TextBox txtEmail;
        private TextBox txtCelular;
    }
}