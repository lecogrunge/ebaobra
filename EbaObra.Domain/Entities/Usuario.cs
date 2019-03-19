using EbaObra.Domain.Entities.Base;
using EbaObra.Domain.Enum;
using EbaObra.Domain.Extensions;
using EbaObra.Domain.ValueObjects;
using System;

namespace EbaObra.Domain.Entities
{
    public sealed class Usuario : EntityBase
    {
        private Usuario()
        {

        }

        public Usuario(Nome nome, Email email, string senha, EnumTipoUsuario tipoUsuario)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha.Criptografar("jdfsjds");
            this.DataCadastro = DateTime.Now;
            this.Status = EnumStatusUsuario.AguardandoConfirmacaoEmail;
            this.TipoUsuario = TipoUsuario;
        }
        
        public Nome Nome { get; private set; }
        public Email Email { get; private set; }
        public string Senha { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public EnumStatusUsuario Status { get; private set; }
        public EnumTipoUsuario TipoUsuario { get; private set; }
    }
}