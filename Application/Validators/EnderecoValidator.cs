using Domain.Models;
using FluentValidation;
using Domain.Enums;
using Domain.Utils;
using Infra.Persistence;
namespace Application.Validators;

public class EnderecoValidator : AbstractValidator<Endereco>
{
    public EnderecoValidator()
    {
    }
}