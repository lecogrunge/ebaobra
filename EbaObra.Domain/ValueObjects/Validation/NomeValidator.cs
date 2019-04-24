using FluentValidation;

namespace EbaObra.Domain.ValueObjects.Validation
{
	public sealed class NomeValidator : AbstractValidator<Nome>
	{
		public NomeValidator()
		{
			RuleFor(s => s.PrimeiroNome).Cascade(CascadeMode.StopOnFirstFailure)
										.NotEmpty().WithMessage("");

			RuleFor(s => s.Sobrenome).Cascade(CascadeMode.StopOnFirstFailure)
										.NotEmpty().WithMessage("");
		}
	}
}