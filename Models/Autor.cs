using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SiteNoticias.Models
{
     [Table("Autores")]
    public class Autor
        {
            [Key]
            public int AutorID { get; set; }
            [Required]
            [MinLength(10)]
            [MaxLength(50)]
            public string Nome { get; set; }
            public string Telefone { get; set; }
            public DateTime DataNascimento { get; set; }
            public string Historia { get; set; }

        }
}