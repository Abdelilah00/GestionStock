using GestionStock.Forms.Facture;
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
    public partial class FactureList : Form
    {
        public FactureList()
        {
            InitializeComponent();
        }

        private void FactureList_Load(object sender, EventArgs e)
        {
            DatabaseContext context = new DatabaseContext();
            dataGridView1.DataSource = context.Factures.ToList();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            var form = new FactureEdit();
            form.Show();
        }
    }
}
