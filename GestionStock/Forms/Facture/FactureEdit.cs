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
            var ProductId = Convert.ToInt32(cb_prod.SelectedValue);
            var ClientId = Convert.ToInt32(cb_client.SelectedValue);

            var facture = new Models.Facture
            {
                Reference = input_ref.Text,
                Qte = Convert.ToInt32(input_qte.Text),
                ProductId = Convert.ToInt32(cb_prod.ValueMember),
                ClientId = Convert.ToInt32(cb_client.ValueMember),
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
