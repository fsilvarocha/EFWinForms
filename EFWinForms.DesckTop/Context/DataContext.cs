using EFWinForms.DesckTop.Models;
using Microsoft.EntityFrameworkCore;

namespace EFWinForms.DesckTop.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer("Server=localhost;Database=EFWF;User Id=sa;Password=SqlServer@Docker19;");

    }
}
