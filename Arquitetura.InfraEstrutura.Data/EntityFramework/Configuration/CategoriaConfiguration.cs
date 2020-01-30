using Arquitetura.Dominio.VendasContext.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Arquitetura.InfraEstrutura.Data.EntityFramework.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");
            builder.HasKey(x => x.CategoriaId);

            builder.Property(x => x.CategoriaId).HasColumnName(@"CategoriaId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Nome).HasColumnName(@"Nome").HasColumnType("varchar(100)").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName(@"Descricao").HasColumnType("varchar(100)");
        }
    }
}
