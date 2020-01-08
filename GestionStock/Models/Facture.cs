using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace GestionStock.Models
{
    public class Facture
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }

        [Column(Name = "reference", DbType = "VARCHAR")]
        public String Reference { get; set; }

        [Column(Name = "qte", DbType = "INTEGER")]
        public int Qte { get; set; }

        [Column(Name = "productId", DbType = "INTEGER")]
        public int ProductId { get; set; }
    }

}