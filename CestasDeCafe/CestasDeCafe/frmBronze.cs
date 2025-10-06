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
    public partial class frmBronze : Form
    {
        public frmBronze()
        {
            InitializeComponent();
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

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

            decimal valorCesta = 75.00m;
            decimal quantidadeCestas = numQuantidade.Value;
            lblValor.Text = (valorCesta * quantidadeCestas).ToString("C");
        }

        private void lblValor_Click(object sender, EventArgs e)
        {
        }
    }
}
