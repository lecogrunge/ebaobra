using EbaObra.Domain.Entities.Base;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class TipoEmpresa : EntityBase
    {
        private TipoEmpresa()
        {

        }

        public int IdTipoEmpresa { get; private set; }
        public string Descricao { get; private set; }

        public ICollection<Empresa> ListaEmpresas { get; private set; }
    }
}