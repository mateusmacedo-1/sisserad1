using Domain.InputModels;
using FluentValidation;

namespace ClientBlazor.Validators
{
    public class EnderecoFormValidator : AbstractValidator<EnderecoInputModel>
    {
        public EnderecoFormValidator()
        {
            RuleFor(endereco => endereco.Logradouro)
                .NotEmpty().WithMessage("O logradouro é obrigatório.")
                .MaximumLength(250).WithMessage("O logradouro deve ter no máximo 250 caracteres.")
                .MinimumLength(5).WithMessage("O logradouro deve ter pelo menos 5 caracteres.");

            RuleFor(endereco => endereco.Numero)
                .NotEmpty().WithMessage("O número é obrigatório.");

            RuleFor(endereco => endereco.Cep)
                .NotEmpty().WithMessage("O CEP é obrigatório.")
                .MaximumLength(10).WithMessage("O CEP deve ter no máximo 10 caracteres.")
                .MinimumLength(8).WithMessage("O CEP deve ter pelo menos 8 caracteres.");

            RuleFor(endereco => endereco.Complemento)
                .MaximumLength(100).WithMessage("O complemento deve ter no máximo 100 caracteres.");

        }

        public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
        {
            var result = await ValidateAsync(ValidationContext<EnderecoInputModel>.CreateWithOptions((EnderecoInputModel)model, x => x.IncludeProperties(propertyName)));
            if (result.IsValid)
                return Array.Empty<string>();
            return result.Errors.Select(e => e.ErrorMessage);
        };
    }
}