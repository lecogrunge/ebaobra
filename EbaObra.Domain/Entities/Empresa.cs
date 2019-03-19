using EbaObra.Domain.Entities.Base;
using EbaObra.Domain.ValueObjects;
using System;

namespace EbaObra.Domain.Entities
{
    public sealed class Empresa : EntityBase
    {
        private Empresa()
        {

        }

        public Guid IdEmpresa { get; private set; }
        public string NomeFantasia { get; private set; }
        public string Logradouro { get; private set; }
        public string Numero { get; private set; }
        public string Complemento { get; private set; }
        public string CEP { get; private set; }
        public string Latitude { get; private set; }
        public string Longitude { get; private set; }
        public Email EmailContato { get; private set; }
        public string Website { get; private set; }
        public bool Ativo { get; private set; }

        public Arquivo Logo { get; private set; }
        public Usuario Usuario { get; private set; }
    }
}