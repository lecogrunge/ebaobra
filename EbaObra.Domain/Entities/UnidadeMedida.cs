using EbaObra.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class UnidadeMedida : EntityBase
    {
        private UnidadeMedida()
        {

        }

        public Guid IdUnidadeMedida { get; private set; }
        public string Descricao { get; private set; }
        public string Sigla { get; private set; }

        public ICollection<Produto> ListaProduto { get; private set; }
    }
}