using EbaObra.Domain.Entities.Base;
using System.Collections.Generic;

namespace EbaObra.Domain.Entities
{
    public sealed class EmpresaProduto : EntityBase
    {
        private EmpresaProduto()
        {

        }

        public decimal Preco { get; private set; }
        public bool Ativo { get; private set; }

        public ICollection<Empresa> ListaEmpresa { get; private set; }
        public ICollection<Produto> ListaProduto { get; private set; }
    }
}