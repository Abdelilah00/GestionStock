using GestionStock.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionStock.Forms.Facture
{
    public partial class FactureEdit : Form
    {
        public FactureEdit()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, System.EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            var facture = new Models.Facture
            {
             
                Qte = Convert.ToInt32(numericUpDown1.Text),
                ProductId = (cb_prod.SelectedItem as Product).Id,
                ClientId = (cb_client.SelectedItem as Client).Id,
            };
            context.Factures.Add(facture);
            context.SaveChanges();
        }

        private void FactureEdit_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            var items = context.Products.ToList();
            foreach (var item in items)
            {
                cb_prod.Items.Add(item);
            }
            var items1 = context.Clients.ToList();
            foreach (var item in items1)
            {
                cb_client.Items.Add(item);
            }
        }
    }
}
