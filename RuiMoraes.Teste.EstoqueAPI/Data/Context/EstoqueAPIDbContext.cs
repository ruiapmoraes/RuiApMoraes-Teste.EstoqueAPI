using Microsoft.EntityFrameworkCore;
using RuiMoraes.Teste.EstoqueAPI.Data.EntitiesConfigurations;
using RuiMoraes.Teste.EstoqueAPI.Domains;

namespace RuiMoraes.Teste.EstoqueAPI.Data.Context
{
    public class EstoqueAPIDbContext : DbContext
    {
        public EstoqueAPIDbContext(DbContextOptions<EstoqueAPIDbContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new CategoriaConfiguration());
            builder.ApplyConfiguration(new ProdutoConfiguration());            
            builder.ApplyConfigurationsFromAssembly(typeof(EstoqueAPIDbContext).Assembly);
        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
