using System;

namespace EbaObra.Domain.Commands.Usuario
{
    public class AutenticarUsuarioResponse : CommandResponse
    {
        public Guid IdUsuario { get; set; }
        public string PrimeiroNome { get; set; }
    }
}