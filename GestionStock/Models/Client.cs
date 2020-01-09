using System.ComponentModel.DataAnnotations;
using System.Data.Linq.Mapping;


namespace GestionStock.Models
{
    [Table(Name = "Client")]
    public class Client
    {
        [Column(Name = "Id", IsDbGenerated = true, IsPrimaryKey = true, DbType = "INTEGER")]
        [Key]
        public int Id { get; set; }

        [Column(Name = "EmpName", DbType = "VARCHAR")]
        public string Nom { get; set; }

        [Column(Name = "Designation", DbType = "VARCHAR")]
        public string PreNom { get; set; }

        public string NomComplet => Nom + " " + PreNom;
    }
}