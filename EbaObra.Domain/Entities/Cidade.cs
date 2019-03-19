using EbaObra.Domain.Entities.Base;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class Cidade : EntityBase
    {
        private Cidade()
        {

        }

        public int IdCidade { get; private set; }
        public string Descricao { get; private set; }

        public ICollection<Bairro> ListaBairro { get; private set; }
        public Estado Estado { get; private set; }
    }
}