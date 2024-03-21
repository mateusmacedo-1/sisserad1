using Domain.Models;
using FluentValidation;
using Domain.Enums;
using Domain.Utils;
using Infra.Persistence;
namespace Application.Validators;

public class ClienteValidator : AbstractValidator<Cliente>
{

    
    private readonly SeradDbContext _context;
    

    public ClienteValidator(SeradDbContext context)
    {
_context = context;
        
RuleFor(c => c)
            .Must(c => !ClienteExiste(c))
            .WithMessage("Cliente já cadastrado.");;

        When(c => c.Tipo == TipoCliente.Física, () => {
                RuleFor(c => c.Documento)
                    .NotNull()
                    .Must(d => CpfValido(d))
                    .WithMessage("Cpf inválido.");
        });

        When(c => c.Tipo == TipoCliente.Jurídica, () => {
                RuleFor(c => c.Documento)
                    .NotNull()
                    .Must(d => CnpjValido(d))
                    .WithMessage("Cnpj inválido.");
        });

}
    private bool ClienteExiste(Cliente cliente)
    {
        var clienteExiste = _context.Clientes.ToList().Exists(c => DocumentoUtils.RemoverPontuacaoDocumento(c) == DocumentoUtils.RemoverPontuacaoDocumento(cliente));
        if (clienteExiste) return true;
        return false;
    }

    private static bool CpfValido(string? cpf)
    {
        return DocumentoUtils.ValidarCpf(cpf ?? "");
    }

    private static bool CnpjValido(string? cnpj)
    {
        return DocumentoUtils.ValidarCnpj(cnpj ?? "");
    }
}