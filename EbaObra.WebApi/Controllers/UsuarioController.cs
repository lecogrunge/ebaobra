using EbaObra.Domain.Commands.Usuario;
using EbaObra.Domain.Interfaces.Services;
using EbaObra.Shared.Transactions;
using EbaObra.WebApi.Controllers.Base;
using EbaObra.WebApi.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading.Tasks;

namespace EbaObra.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : BaseController
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUnitOfWork unitOfWork, IUsuarioService usuarioService, IHttpContextAccessor httpContextAccessor) : base(unitOfWork, httpContextAccessor)
        {
            _usuarioService = usuarioService;
        }

        #region Site
        [AllowAnonymous]
        [HttpPost]
        [Route("api/[controller]/Adicionar")]
        public async Task<IActionResult> Adicionar([FromBody] CadastrarUsuarioRequest request)
        {
            try
            {
                CadastrarUsuarioResponse response = _usuarioService.CadastrarUsuario(request);
                if(response.Success)
                {
                    _unitOfWork.Commit();
                    return Ok(response);
                }

                return BadRequest(new { erros = request.Notifications });
            }
            catch (Exception ex)
            {
                return BadRequest("Houve um problema interno no servidor.");
            }
        }
        
        [AllowAnonymous]
        [HttpPost]
        [Route("api/[controller]/Autenticar")]
        public object Autenticar([FromBody]AutenticarUsuarioRequest request, [FromServices]SigningConfiguration signingConfigurations, [FromServices]TokenConfigurations tokenConfigurations)
        {
            bool credenciaisValidas = false;
            AutenticarUsuarioResponse response = _usuarioService.AutenticarUsuario(request);

            credenciaisValidas = response != null;
            if (credenciaisValidas)
            {
                ClaimsIdentity identity = new ClaimsIdentity(
                    new GenericIdentity(response.IdUsuario.ToString(), "Id"),
                    new[] {
                        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString("N")),
                        new Claim("Usuario", JsonConvert.SerializeObject(response)) // 1º param é o nome que recupera no token. 2º param os valores que serão armazenados no token
                    }
                );

                DateTime dataCriacao = DateTime.Now;
                DateTime dataExpiracao = dataCriacao + TimeSpan.FromSeconds(tokenConfigurations.Seconds);

                var handler = new JwtSecurityTokenHandler();
                var securityToken = handler.CreateToken(new SecurityTokenDescriptor
                {
                    Issuer = tokenConfigurations.Issuer,
                    Audience = tokenConfigurations.Audience,
                    SigningCredentials = signingConfigurations.SigningCredentials,
                    Subject = identity,
                    NotBefore = dataCriacao,
                    Expires = dataExpiracao
                });

                var token = handler.WriteToken(securityToken);

                return new
                {
                    authenticated = true,
                    created = dataCriacao.ToString("yyyy-MM-dd HH:mm:ss"),
                    expiration = dataExpiracao.ToString("yyyy-MM-dd HH:mm:ss"),
                    accessToken = token,
                    message = "OK",
                    primeiroNomeDoProprietario = response.PrimeiroNome
                };
            }
            else
            {
                return new
                {
                    authenticated = false,
                    request.Notifications
                };
            }
        }
        #endregion
    }
}