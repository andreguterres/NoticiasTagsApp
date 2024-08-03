using Azure;
using Microsoft.EntityFrameworkCore;
using NoticiasTagsApp.Models;

namespace NoticiasTagsApp.Context
{
    public class Contexto : DbContext
    {    

            public Contexto(DbContextOptions<Contexto> options) : base(options) { }

            public DbSet<Usuario> Usuarios { get; set; }
            public DbSet<Noticia> Noticias { get; set; }
            public DbSet<Tag> Tags { get; set; }
            public DbSet<NoticiaTag> NoticiaTags { get; set; }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                // Configuração das chaves primárias e estrangeiras
                modelBuilder.Entity<Usuario>()
                    .HasKey(u => u.Id);

                modelBuilder.Entity<Noticia>()
                    .HasKey(n => n.Id);

                modelBuilder.Entity<Noticia>()
                    .HasOne(n => n.Usuario)
                    .WithMany(u => u.Noticias)
                    .HasForeignKey(n => n.UsuarioId);

                modelBuilder.Entity<Tag>()
                    .HasKey(t => t.Id);

                modelBuilder.Entity<NoticiaTag>()
                    .HasKey(nt => nt.Id);

                modelBuilder.Entity<NoticiaTag>()
                    .HasOne(nt => nt.Noticia)
                    .WithMany(n => n.NoticiaTags)
                    .HasForeignKey(nt => nt.NoticiaId);

                modelBuilder.Entity<NoticiaTag>()
                    .HasOne(nt => nt.Tag)
                    .WithMany(t => t.NoticiaTags)
                    .HasForeignKey(nt => nt.TagId);
            }
        }
    }

