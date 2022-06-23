using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SiteNoticias.Models
{
    [Table("Noticias")]
    public class Noticia
        {
            [Key]
            public int NoticiaID { get; set; }
            [ForeignKey("Autor")]
            public int AutorID { get; set; }
            public virtual Autor Autor{ get; set; }
            public string Titulo { get; set;}
            public DateTime Data { get; set; } 
            public string Conteudo { get; set; } 
 
        }
}