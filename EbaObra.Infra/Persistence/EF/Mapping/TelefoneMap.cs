using EbaObra.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            // Nome da tabela
            builder.ToTable("Usuario");

            // Chave primaria
            builder.HasKey(x => x.Id);
        }
    }
}