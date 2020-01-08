using System;
using System.Collections.Generic;
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
            context.Factures.Add(new Models.Facture
            {
                Reference = input_ref.Text,
                ProductId =Convert.ToInt32(cb_prod.Text) ,
                Qte = Convert.ToInt32(input_qte.Text) ,
            });
            context.SaveChanges();
        }

        private void FactureEdit_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            cb_prod.Items.Add(new Models.Product());
        }
    }
}
