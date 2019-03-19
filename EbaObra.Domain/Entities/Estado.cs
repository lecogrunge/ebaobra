using EbaObra.Domain.Entities.Base;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class Estado : EntityBase
    {
        private Estado()
        {

        }

        public string SiglaEstado { get; private set; }
        public string Nome { get; private set; }

        public ICollection<Cidade> ListaCidade { get; private set; }
    }
}