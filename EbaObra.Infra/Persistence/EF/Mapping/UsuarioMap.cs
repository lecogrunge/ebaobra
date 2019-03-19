using EbaObra.Domain.Entities;
using EbaObra.Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EbaObra.Infra.Persistence.EF.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // Nome da tabela
            builder.ToTable("Usuario");

            // Chave primaria
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Senha).HasMaxLength(36).IsRequired();

            // Mapeando objetos de valor
            builder.OwnsOne<Nome>(x => x.Nome, cb =>
            {
                cb.Property(x => x.PrimeiroNome).HasMaxLength(20).HasColumnName("PrimeiroNome").IsRequired();
                cb.Property(x => x.Sobrenome).HasMaxLength(50).HasColumnName("Sobrenome").IsRequired();
            });

            builder.OwnsOne<Email>(x => x.Email, cb =>
            {
                cb.Property(x => x.EnderecoEmail).HasMaxLength(70).HasColumnName("Email").IsRequired();
            });
        }
    }
}