using EbaObra.Domain.Commands.Usuario;
using EbaObra.Shared.Transactions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EbaObra.WebApi.Controllers.Base
{
    public class BaseController : Controller
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly AutenticarUsuarioResponse _dadosUsuarioAutenticado;
        //private IServiceBase _serviceBase;

        public BaseController(IUnitOfWork unitOfWork, IHttpContextAccessor httpContextAccessor)
        {
            _unitOfWork = unitOfWork;

            string usuarioClaims = httpContextAccessor.HttpContext.User.FindFirst("Usuario").Value;
            _dadosUsuarioAutenticado = JsonConvert.DeserializeObject<AutenticarUsuarioResponse>(usuarioClaims);
        }

        //public async Task<IActionResult> ResponseAsync(object result, IServiceBase serviceBase)
        //{
        //    _serviceBase = serviceBase;
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (_serviceBase != null)
        //        _serviceBase.Dispose();

        //    base.Dispose(disposing);
        //}
    }
}