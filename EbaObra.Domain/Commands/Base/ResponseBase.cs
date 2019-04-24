using EbaObra.Domain.Interfaces.Commands.Base;
using System.Collections.Generic;
using System.Linq;

namespace EbaObra.Domain.Commands.Base
{
	public abstract class ResponseBase : IResponseBase
	{
		public ResponseBase()
		{
			ListaErros = new List<ErrorResponse>();
		}

		public IList<ErrorResponse> ListaErros { get; private set; }

		public bool IsValido()
		{
			return !ListaErros.Any();
		}
	}
}