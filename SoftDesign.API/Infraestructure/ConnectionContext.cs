using Microsoft.EntityFrameworkCore;
using SoftDesign.API.Domain.Models;

namespace SoftDesign.API.Infraestructure
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Livro> Livros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer(
                "Data Source=NITRO-MICHEL;Initial Catalog=Livraria;User ID=sa;Password=dell23");
    }
}
