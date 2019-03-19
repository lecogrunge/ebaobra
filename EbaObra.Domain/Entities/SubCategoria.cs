using EbaObra.Domain.Entities.Base;
using System;

namespace EbaObra.Domain.Entities
{
    public sealed class SubCategoria : EntityBase
    {
        private SubCategoria()
        {

        }

        public Guid IdSubCategoria { get; private set; }
        public string Descricao { get; private set; }

        public Categoria Categoria { get; private set; }
    }
}