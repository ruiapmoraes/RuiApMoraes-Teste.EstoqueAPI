using Microsoft.EntityFrameworkCore;
using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Context
{
    public class EstoqueAPIDbContext : DbContext
    {
        public EstoqueAPIDbContext(DbContextOptions<EstoqueAPIDbContext> options)
            : base(options)
        {

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);            
            builder.ApplyConfigurationsFromAssembly(typeof(EstoqueAPIDbContext).Assembly);
        }
    }
}
