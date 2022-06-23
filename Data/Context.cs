using System;
using Microsoft.EntityFrameworkCore;
using SiteNoticias.Models;

namespace SiteNoticias.Data
{
    public class Context : DbContext
    {
         public Context(DbContextOptions<Context> options) : base (options)
       {

       }
           public DbSet<Autor> Autores {get;set;}

           public DbSet<Noticia> Noticias {get;set;}
   }
}