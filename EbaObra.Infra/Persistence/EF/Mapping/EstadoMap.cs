using EbaObra.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            // Nome da tabela
            builder.ToTable("Estado");

            // Chave primaria
            builder.HasKey(x => x.Id);
        }
    }
}