using Azure;
using Microsoft.EntityFrameworkCore;
using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Context
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options)
        : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<NoticiaModel> Noticias { get; set; }
        public DbSet<TagModel> Tags { get; set; }
        public DbSet<NoticiaTagModel> NoticiaTags { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<NoticiaTagModel>()
        //        .HasKey(nt => nt.Id);

        //    modelBuilder.Entity<NoticiaTagModel>()
        //        .HasOne(nt => nt.Noticia)
        //        .WithMany(n => n.NoticiaTags)
        //        .HasForeignKey(nt => nt.NoticiaId);

        //    modelBuilder.Entity<NoticiaTagModel>()
        //        .HasOne(nt => nt.Tag)
        //        .WithMany(t => t.NoticiaTags)
        //        .HasForeignKey(nt => nt.TagId);
        //}
    }
}
