using Domain.Models;
using FluentValidation;

namespace Application.Validators;

public class EnderecoValidator : AbstractValidator<Endereco>
{
    public EnderecoValidator()
    {
    }
}