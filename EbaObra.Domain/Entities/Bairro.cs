using EbaObra.Domain.Entities.Base;

namespace EbaObra.Domain.Entities
{
    public sealed class Bairro : EntityBase
    {
        private Bairro()
        {

        }

        public int IdBairro { get; private set; }
        public string Nome { get; private set; }

        public Cidade Cidade { get; private set; }
    }
}