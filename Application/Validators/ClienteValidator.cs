using Domain.Models;
using FluentValidation;
using Domain.Enums;
using Domain.Utils;
using Infra.Persistence;
namespace Application.Validators;

public class ClienteValidator : AbstractValidator<Cliente>
{


    private readonly SeradDbContext? _context ;
    

    public ClienteValidator()
    {
        RuleFor(c => c)
            .Must(ClienteNãoExiste);

        When(c => c.Tipo == TipoCliente.Física, () => {
                RuleFor(c => c.Documento)
                    .Must(CpfValido);
        });

        When(c => c.Tipo == TipoCliente.Jurídica, () => {
                RuleFor(c => c.Documento)
                    .Must(CnpjValido);
        });

    }

    private bool CpfValido(string cpf)
    {
        return DocumentoUtils.ValidarCpf(cpf);
    }

    private bool CnpjValido(string cnpj)
    {
        return DocumentoUtils.ValidarCnpj(cnpj);
    }

    private bool ClienteNãoExiste(Cliente cliente)
    {
        var clienteExistente = _context.Clientes
        .Where(c => DocumentoUtils.RemoverPontuacaoDocumento(c) == DocumentoUtils.RemoverPontuacaoDocumento(cliente))
        .SingleOrDefault();

        if (clienteExistente != null) return true;
        return false;
    }
}