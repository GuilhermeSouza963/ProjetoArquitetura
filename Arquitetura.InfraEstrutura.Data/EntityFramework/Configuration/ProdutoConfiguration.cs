using Arquitetura.Dominio.VendasContext.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arquitetura.InfraEstrutura.Data.EntityFramework.Configuration
{
    public class ProdutoConfiguration : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");
            builder.HasKey(x => x.ProdutoId);

            builder.Property(x => x.ProdutoId).HasColumnName(@"ProdutoId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(100)");
            builder.Property(x => x.Preco).HasColumnName(@"Preco").HasColumnType("decimal").IsRequired();
            builder.Property(x => x.Quantidade).HasColumnName(@"Quantidade").HasColumnType("int").IsRequired();
            builder.Property(x => x.CategoriaId).HasColumnName(@"CategoriaId").HasColumnType("int").IsRequired();
        }
    }
}
