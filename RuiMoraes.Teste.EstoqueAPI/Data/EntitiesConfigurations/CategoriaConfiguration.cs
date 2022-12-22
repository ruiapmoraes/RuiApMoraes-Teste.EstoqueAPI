using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;

namespace RuiMoraes.Teste.EstoqueAPI.Data.EntitiesConfigurations
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Nome).HasMaxLength(30).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(100);
        }
    }
}
