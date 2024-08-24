using Biblioteca_Virtual.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace Biblioteca_Virtual.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) 
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<LivroModel> Livro { get; set; }
        public DbSet<EmprestimoModel> Emprestimo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmprestimoModel>()
                .HasKey(e => new { e.UsuarioId, e.LivroId });

            modelBuilder.Entity<EmprestimoModel>()
                .HasOne(l => l.Livro)
                .WithOne(e => e.Emprestimo)
                .HasForeignKey<EmprestimoModel>(l => l.LivroId);

            modelBuilder.Entity<EmprestimoModel>()
                .HasOne(u => u.Usuario)
                .WithMany(e => e.Emprestimo)
                .HasForeignKey(u => u.UsuarioId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
