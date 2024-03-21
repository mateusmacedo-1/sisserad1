
using FluentValidation;
using Domain.Enums;
using Domain.Utils;
using Domain.InputModels;


namespace ClientBlazor.Validators;

public class ClienteFormValidator : AbstractValidator<CreateClienteInputModel>
{

    public ClienteFormValidator()
    {


        When(c => c.Tipo == TipoCliente.Física, () =>
        {
            RuleFor(c => c.Documento)
                .NotNull()
                .Must(d => CpfValido(d))
                .WithMessage("Cpf inválido.");
        });

        When(c => c.Tipo == TipoCliente.Jurídica, () =>
        {
            RuleFor(c => c.Documento)
                .NotNull()
                .Must(d => CnpjValido(d))
                .WithMessage("Cnpj inválido.");
        });

        RuleFor(cliente => cliente.Nome)
            .NotEmpty().WithMessage("O nome é obrigatório.")
            .MaximumLength(250).WithMessage("O nome deve ter no máximo 250 caractéres.")
            .MinimumLength(10).WithMessage("O nome deve ter pelo menos 10 caractéres.");

        RuleFor(cliente => cliente.Representante)
            .NotEmpty().WithMessage("O nome do representante é obrigatório.")
            .MaximumLength(250).WithMessage("O nome do representante deve ter no máximo 250 caractéres.")
            .MinimumLength(10).WithMessage("O nome do representante deve ter pelo menos 10 caractéres.");

        RuleFor(cliente => cliente.Email)
            .NotEmpty().WithMessage("O e-mail é obrigatório.")
            .MaximumLength(250).WithMessage("O e-mail deve ter no máximo 250 caractéres.")
            .MinimumLength(10).WithMessage("O e-mail deve ter pelo menos 10 caractéres.")
            .EmailAddress().WithMessage("E-mail inválido.");

        RuleFor(cliente => cliente.Telefone)
            .NotEmpty().WithMessage("O Telefone é obrigatório.")
            .MaximumLength(20).WithMessage("O Telefone deve ter no máximo 20 caractéres.")
            .MinimumLength(8).WithMessage("O Telefone deve ter pelo menos 8 caractéres.");

        RuleFor(cliente => cliente.Documento)
            .NotEmpty().WithMessage("O Documento é obrigatório.")
            .MaximumLength(15).WithMessage("O Documento deve ter no máximo 15 caractéres.")
            .MinimumLength(10).WithMessage("O Documento deve ter pelo menos 10 caractéres.");

        RuleFor(cliente => cliente.Tipo)
            .NotNull().WithMessage("O Tipo do Cliente é obrigatório.")
            .IsInEnum().WithMessage("Tipo de cliente inválido.");

        RuleFor(cliente => cliente.Endereco)
				.SetValidator(new EnderecoFormValidator());

    }

    private static bool CpfValido(string? cpf)
    {
        return DocumentoUtils.ValidarCpf(cpf ?? "");
    }

    private static bool CnpjValido(string? cnpj)
    {
        return DocumentoUtils.ValidarCnpj(cnpj ?? "");
    }
    public Func<object, string, Task<IEnumerable<string>>> ValidateValue => async (model, propertyName) =>
    {
        var result = await ValidateAsync(ValidationContext<CreateClienteInputModel>.CreateWithOptions((CreateClienteInputModel)model, x => x.IncludeProperties(propertyName)));
        if (result.IsValid)
            return Array.Empty<string>();
        return result.Errors.Select(e => e.ErrorMessage);
    };
}