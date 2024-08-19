using Biblioteca_Virtual.Models;
using Microsoft.EntityFrameworkCore;

namespace Biblioteca_Virtual.Data
{
    public class ContextDb : DbContext
    {
        public ContextDb(DbContextOptions<ContextDb> options) : base(options) 
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
