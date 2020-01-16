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

       

        public int Qte { get; set; }

        public int ProductId { get; set; }
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }
        public virtual Product Product { get; set; }
    }

}