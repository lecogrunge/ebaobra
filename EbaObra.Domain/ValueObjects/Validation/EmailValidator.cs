using FluentValidation;

namespace EbaObra.Domain.ValueObjects.Validation
{
	public sealed class EmailValidator : AbstractValidator<Email>
	{
		public EmailValidator()
		{
			RuleFor(s => s.EnderecoEmail).Cascade(CascadeMode.StopOnFirstFailure)
										 .NotEmpty().WithMessage("E-mail é obrigatório")
										 .EmailAddress().WithMessage("E-mail inválido");
		}
	}
}