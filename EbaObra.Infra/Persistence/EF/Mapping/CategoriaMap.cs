using EbaObra.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class CategoriaMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            // Nome da tabela
            builder.ToTable("Categoria");

            // Chave primaria
            builder.HasKey(x => x.Id);
        }
    }
}