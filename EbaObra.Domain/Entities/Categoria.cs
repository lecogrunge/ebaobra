using EbaObra.Domain.Entities.Base;
using System;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class Categoria : EntityBase
    {
        private Categoria()
        {

        }

        public Guid IdCategoria { get; private set; }
        public string Descricao { get; private set; }

        public ICollection<SubCategoria> ListaSubCategoria { get; set; }
    }
}