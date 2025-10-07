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
            decimal valorCompra = valorCesta * quantidadeCestas;
            lblValor.Text = valorCompra.ToString("C");
        }

        private void btnPagamento_Click(object sender, EventArgs e)
        {
            frmPagamento pagamento = new frmPagamento();

            this.Hide();
            pagamento.ShowDialog();
            this.Show();

        }
    }
}
