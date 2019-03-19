using EbaObra.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class TipoEmpresaMap : IEntityTypeConfiguration<TipoEmpresa>
    {
        public void Configure(EntityTypeBuilder<TipoEmpresa> builder)
        {
            // Nome da tabela
            builder.ToTable("TipoEmpresa");

            // Chave primaria
            builder.HasKey(x => x.Id);
        }
    }
}