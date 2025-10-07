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
        decimal valorCompra = 0.00m;
        public frmPersonalizado()
        {
            InitializeComponent();
        }
        private decimal ObterPreco(string produto)
        {
            switch (produto)
            {
                case "Café Solúvel": return 4.00m;
                case "Cappuccino": return 6.00m;
                case "Chá": return 3.00m;
                case "Torrada": return 8.00m;
                case "Bolacha Champanhe": return 10.00m;
                case "Cookies": return 9.00m;
                case "Geleia": return 15.00m;
                case "Nutella": return 13.00m;
                case "Uvas": return 4.00m;
                case "Buquê de Rosas": return 25.00m;
                default: return 0m;
            }
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
                valorCompra += cafeSoluvel;
                lstProdutos.Items.Add("Café Solúvel");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnCapuccinno_Click(object sender, EventArgs e)
        {
            decimal capuccino = 6.00m;

            if (btnCapuccinno_Click != null)
            {
                valorCompra += capuccino;
                lstProdutos.Items.Add("Cappuccino");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnCha_Click(object sender, EventArgs e)
        {
            decimal cha = 3.00m;

            if (btnCha_Click != null)
            {
                valorCompra += cha;
                lstProdutos.Items.Add("Chá");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnTorrada_Click(object sender, EventArgs e)
        {
            decimal torrada = 8.00m;

            if (btnTorrada_Click != null)
            {
                valorCompra += torrada;
                lstProdutos.Items.Add("Torrada");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnBolacha_Click(object sender, EventArgs e)
        {
            decimal bolachaChampanhe = 10.00m;

            if (btnBolacha_Click != null)
            {
                valorCompra += bolachaChampanhe;
                lstProdutos.Items.Add("Bolacha Champanhe");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnCookies_Click(object sender, EventArgs e)
        {
            decimal cookies = 9.00m;

            if (btnCookies_Click != null)
            {
                valorCompra += cookies;
                lstProdutos.Items.Add("Cookies");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnGeleia_Click(object sender, EventArgs e)
        {
            decimal geleia = 15.00m;

            if (btnGeleia_Click != null)
            {
                valorCompra += geleia;
                lstProdutos.Items.Add("Geleia");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnNutella_Click(object sender, EventArgs e)
        {
            decimal nutella = 13.00m;

            if (btnNutella_Click != null)
            {
                valorCompra += nutella;
                lstProdutos.Items.Add("Nutella");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnUvas_Click(object sender, EventArgs e)
        {
            decimal uvas = 4.00m;

            if (btnUvas_Click != null)
            {
                valorCompra += uvas;
                lstProdutos.Items.Add("Uvas");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnRosas_Click(object sender, EventArgs e)
        {
            decimal rosas = 25.00m;

            if (btnRosas_Click != null)
            {
                valorCompra += rosas;
                lstProdutos.Items.Add("Buquê de Rosas");
            }

            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento(valorCompra);

            this.Hide();
            pagamento.ShowDialog();
            this.Show();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstProdutos.SelectedIndex != -1)
            {
                string produtoSelecionado = lstProdutos.SelectedItem.ToString();
                valorCompra -= ObterPreco(produtoSelecionado);
                lstProdutos.Items.RemoveAt(lstProdutos.SelectedIndex);
                lblValor.Text = valorCompra.ToString("C");
            }
            else
            {
                MessageBox.Show("Selecione um item para excluir!");
            }
        }
    }
}
