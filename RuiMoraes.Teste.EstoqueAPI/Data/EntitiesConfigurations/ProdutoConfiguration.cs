﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RuiMoraes.Teste.EstoqueAPI.Domains;
using RuiMoraes.Teste.EstoqueAPI.Domains.Enum;

namespace RuiMoraes.Teste.EstoqueAPI.Data.EntitiesConfigurations
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(p => p.Nome).HasMaxLength(100).IsRequired();
            builder.Property(p => p.Descricao).HasMaxLength(200).IsRequired();

            builder.Property(p => p.Preco).HasPrecision(10, 2);

            builder.HasOne(e => e.Categoria).WithMany(e => e.Produtos)
                .HasForeignKey(e => e.CategoriaId);
        }
    }
}
