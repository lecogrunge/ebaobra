using EbaObra.Domain.Entities.Base;
using EbaObra.Domain.Enum;

namespace EbaObra.Domain.Entities
{
    public sealed class Arquivo : EntityBase
    {
        private Arquivo()
        {

        }

        public int IdArquivo { get; private set; }
        public string Nome { get; private set; }
        public string Extensao { get; private set; }
        public EnumTipoArquivo TipoArquivo { get; private set; }
        public int TamanhoKB { get; private set; }
        public string Diretorio { get; private set; }

        public Empresa Empresa { get; private set; }
    }
}