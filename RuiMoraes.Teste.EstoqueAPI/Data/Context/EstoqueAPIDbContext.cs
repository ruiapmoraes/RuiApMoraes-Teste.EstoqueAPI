using Microsoft.EntityFrameworkCore;
using RuiMoraes.Teste.EstoqueAPI.Data.EntitiesConfigurations;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using System.Reflection.Emit;
using System.Reflection.Metadata;

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
            //builder.ApplyConfiguration(new CategoriaConfiguration());
            //builder.ApplyConfiguration(new ProdutoConfiguration());            
            builder.Entity<Categoria>()
                .Property(c => c.Id)
                .ValueGeneratedNever();

            builder.Entity<Produto>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            builder.ApplyConfigurationsFromAssembly(typeof(EstoqueAPIDbContext).Assembly);

        }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
