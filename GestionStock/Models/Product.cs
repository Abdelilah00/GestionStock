using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStock.Models
{
    public class Product
    {
        public int Id { get; set; }
        public String Libelle { get; set; }
        public int Qte { get; set; }
    }

}