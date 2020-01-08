using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;

namespace GestionStock.Models
{
    [Table(Name = "Product")]
    public class Product
    {
        [Column(Name = "id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }

        [Column(Name = "libelle", DbType = "VARCHAR")]
        public string Libelle { get; set; }

        [Column(Name = "qte", DbType = "INTEGER")]
        public int Qte { get; set; }
    }
}