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
    public partial class frmOuro : Form
    {
        decimal valorCompra = 0.00m;
        public frmOuro()
        {
            InitializeComponent();
        }

        private void numQuantidade_ValueChanged(object sender, EventArgs e)
        {
            if (numQuantidade.Value == 0)
            {
                MessageBox.Show(
                    "Escolha uma quantidade diferente de zero!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                numQuantidade.Value = 1;
            }

            decimal valorCesta = 180.00m;
            decimal quantidadeCestas = numQuantidade.Value;
            valorCompra = valorCesta * quantidadeCestas;
            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento(valorCompra);

            this.Hide();
            pagamento.ShowDialog();
            this.Show();

        }
    }
}
