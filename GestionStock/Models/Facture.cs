using System;

namespace GestionStock.Models
{
    public class Facture
    {
        public int Id { get; set; }
        public String Reference { get; set; }
        public int Qte { get; set; }
        public int ProductId { get; set; }
    }

}