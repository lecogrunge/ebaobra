namespace EbaObra.Domain.Commands.Base
{
	public sealed class ErrorResponse
	{
		public string Propriedade { get; set; }
		public string Mensagem { get; set; }
	}
}