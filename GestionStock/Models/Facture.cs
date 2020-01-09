using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.ObjectModel;
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
        public string Reference { get; set; }

        [Column(Name = "qte", DbType = "INTEGER")]
        public int Qte { get; set; }

        [ForeignKey(typeof(Product))]
        public int ProductId { get; set; }
        [ForeignKey(typeof(Client))]
        public int ClientId { get; set; }

        [OneToOne]
        public Client Client { get; set; }
        [OneToOne]
        public Product Product { get; set; }
    }

}