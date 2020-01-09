using GestionStock.Forms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GestionStock
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            produit_qte.Text ="Produit Qte : "+ context.Products.Count().ToString();
            client_nbr.Text ="Client Nbr : "+ context.Clients.Count().ToString();
            qte_vendu.Text = "Facture Nbr : "+context.Factures.Count().ToString();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            var form = new FactureList();
            form.ShowDialog();
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            var form = new ClientList();
            form.ShowDialog();
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            var form = new ProductList();
            form.ShowDialog();
        }
    }
}
