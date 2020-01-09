using System;
using System.Windows.Forms;

namespace GestionStock.Forms
{
    public partial class ClientEdit : Form
    {
        public ClientEdit()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            context.Clients.Add(new Models.Client
            {
                Nom = input_nom.Text,
                PreNom = input_prenom.Text
            });
            context.SaveChanges();
        }
    }
}
