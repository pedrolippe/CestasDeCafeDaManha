namespace CestasDeCafe
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnBronze_Click(object sender, EventArgs e)
        {
            frmCestaBronze cestaBronze = new frmCestaBronze();

            this.Hide();
            cestaBronze.ShowDialog();
            this.Show();
        }

        private void btnPrata_Click(object sender, EventArgs e)
        {
            frmPrata cestaPrata = new frmPrata();

            this.Hide();
            cestaPrata.ShowDialog();
            this.Show();
        }

        private void btnOuro_Click(object sender, EventArgs e)
        {
            frmOuro cestaOuro = new frmOuro();

            this.Hide();
            cestaOuro.ShowDialog();
            this.Show();
        }

        private void btnPersonalizar_Click(object sender, EventArgs e)
        {
            frmPersonalizado cestaPersonalizada = new frmPersonalizado();

            this.Hide();
            cestaPersonalizada.ShowDialog();
            this.Show();
        }
    }
}
