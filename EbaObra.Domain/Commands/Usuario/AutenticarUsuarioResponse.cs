using EbaObra.Domain.Commands.Base;
using System;

namespace EbaObra.Domain.Commands.Usuario
{
    public class AutenticarUsuarioResponse : ResponseBase
    {
        public Guid IdUsuario { get; set; }
        public string PrimeiroNome { get; set; }
    }
}