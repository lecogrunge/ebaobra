using EbaObra.Domain.Entities;
using EbaObra.Domain.ValueObjects;
using EbaObra.Infra.Persistence.EF.Mapping;
using EbaObra.Shared;
using Microsoft.EntityFrameworkCore;

namespace EbaObra.Infra.Persistence.EF
{
    public class Context : DbContext
    {
        public DbSet<Arquivo> Arquivos { get; set; }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Empresa> Empresas { get; set; }
        public DbSet<EmpresaProduto> EmpresasProdutos { get; set; }
        public DbSet<SubCategoria> SubCategorias { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Telefone> Telefones { get; set; }
        public DbSet<Token> Tokens { get; set; }
        public DbSet<UnidadeMedida> UnidadeMedidas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseMySql(Settings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // ignorar classes
            modelBuilder.Ignore<Nome>();
            modelBuilder.Ignore<Email>();
            //modelBuilder.Ignore<Notifiable>();

            // aplicar configurações do mapeamento
            modelBuilder.ApplyConfiguration(new UsuarioMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}