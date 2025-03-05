using Microsoft.EntityFrameworkCore;
using WebApi8_Video.Models;

namespace WebApi8_Video.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        // Criação das tabelas no banco de dados
        public DbSet<AutorModel> Autores { get; set; }
        public DbSet<LivroModel> Livros { get; set; }
    }
}
