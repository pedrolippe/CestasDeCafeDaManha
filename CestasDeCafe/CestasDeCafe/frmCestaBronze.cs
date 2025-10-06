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
    public partial class frmCestaBronze : Form
    {
        public frmCestaBronze()
        {
            InitializeComponent();
        }

        private void lstProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProdutos.Items.Clear();
            string[] itens = { "Café Solúvel", "Torrada", "Geleia", "Uvas", "Cookies" };
            lstProdutos.Items.AddRange(itens);

        }
    }
}
