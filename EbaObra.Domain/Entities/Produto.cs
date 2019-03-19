using EbaObra.Domain.Entities.Base;
using System;

namespace EbaObra.Domain.Entities
{
    public sealed class Produto : EntityBase
    {
        private Produto()
        {

        }

        public Guid IdProduto { get; private set; }
        public string Nome { get; private set; }
        public bool Ativo { get; private set; }

        public UnidadeMedida UnidadeMedida { get; private set; }
    }
}