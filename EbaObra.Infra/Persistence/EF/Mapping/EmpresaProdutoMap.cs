using EbaObra.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class EmpresaProdutoMap : IEntityTypeConfiguration<EmpresaProduto>
    {
        public void Configure(EntityTypeBuilder<EmpresaProduto> builder)
        {
            // Nome da tabela
            builder.ToTable("EmpresaProduto");

            // Chave primaria
            builder.HasKey(x => x.Id);
        }
    }
}