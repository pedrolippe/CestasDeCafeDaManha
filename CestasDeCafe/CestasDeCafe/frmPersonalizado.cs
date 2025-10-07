using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CestasDeCafe
{
    public partial class frmPersonalizado : Form
    {
        decimal valorCesta = 0.00m;
        public frmPersonalizado()
        {
            InitializeComponent();
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lstCesta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblValor_Click(object sender, EventArgs e)
        {
            decimal lblValor = 0m;
        }

        private void btnCafe_Click(object sender, EventArgs e)
        {
            decimal cafeSoluvel = 4.00m;

            if (btnCafe_Click != null)
            {
                valorCesta += cafeSoluvel;
                lstProdutos.Items.Add("Café Solúvel");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCapuccinno_Click(object sender, EventArgs e)
        {
            decimal capuccino = 6.00m;

            if (btnCapuccinno_Click != null)
            {
                valorCesta += capuccino;
                lstProdutos.Items.Add("Cappuccino");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            decimal cha = 3.00m;

            if (btnCha_Click != null)
            {
                valorCesta += cha;
                lstProdutos.Items.Add("Chá");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnTorrada_Click(object sender, EventArgs e)
        {
            decimal torrada = 8.00m;

            if (btnTorrada_Click != null)
            {
                valorCesta += torrada;
                lstProdutos.Items.Add("Torrada");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnBolacha_Click(object sender, EventArgs e)
        {
            decimal bolachaChampanhe = 10.00m;

            if (btnBolacha_Click != null)
            {
                valorCesta += bolachaChampanhe;
                lstProdutos.Items.Add("Bolacha Champanhe");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            decimal cookies = 9.00m;

            if (btnCookies_Click != null)
            {
                valorCesta += cookies;
                lstProdutos.Items.Add("Cookies");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnGeleia_Click(object sender, EventArgs e)
        {
            decimal geleia = 15.00m;

            if (btnGeleia_Click != null)
            {
                valorCesta += geleia;
                lstProdutos.Items.Add("Geleia");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnNutella_Click(object sender, EventArgs e)
        {
            decimal nutella = 13.00m;

            if (btnNutella_Click != null)
            {
                valorCesta += nutella;
                lstProdutos.Items.Add("Nutella");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnUvas_Click(object sender, EventArgs e)
        {
            decimal uvas = 4.00m;

            if (btnUvas_Click != null)
            {
                valorCesta += uvas;
                lstProdutos.Items.Add("Uvas");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnRosas_Click(object sender, EventArgs e)
        {
            decimal rosas = 25.00m;

            if (btnRosas_Click != null)
            {
                valorCesta += rosas;
                lstProdutos.Items.Add("Buquê de Rosas");
            }

            lblValor.Text = valorCesta.ToString("C");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();

            this.Hide();
            pagamento.ShowDialog();
            this.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedIndex != -1)
            {
                lstProdutos.Items.RemoveAt(lstProdutos.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir!");
            }
        }
    }
}
