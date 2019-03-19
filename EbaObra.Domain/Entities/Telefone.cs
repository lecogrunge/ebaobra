using EbaObra.Domain.Entities.Base;

namespace EbaObra.Domain.Entities
{
    public sealed class Telefone : EntityBase
    {
        private Telefone()
        {

        }

        public int IdTelefone { get; private set; }
        public string NumeroTelefone { get; private set; }
        public int TipoTelefone { get; private set; }

        public Empresa Empresa { get; private set; }
    }
}