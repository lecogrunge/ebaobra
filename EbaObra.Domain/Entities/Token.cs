using EbaObra.Domain.Entities.Base;
using System;

namespace EbaObra.Domain.Entities
{
    public sealed class Token : EntityBase
    {
        private Token()
        {

        }

        public Guid IdUsuario { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public bool Ativo { get; private set; }
    }
}