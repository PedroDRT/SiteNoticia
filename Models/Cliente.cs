using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteNoticias.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int id { get; set;}
        [Required]
        [MinLength(10)]
        [MaxLength(50)]
        public string Nome { get; set;}
        public string CPF { get; set;}
        public string RG { get; set;}

    }
}