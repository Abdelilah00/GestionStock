using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionStock.Forms
{
    public partial class ProducEdit : Form
    {
        public ProducEdit()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            context.Products.Add(new Models.Product
            {
                Libelle = input_libelle.Text,
                Qte = Convert.ToInt32(input_qte.Text)
            });
            context.SaveChanges();
        }
    }
}
