using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Endereco
{
    public Endereco()
    {
        
    }
    public int? Id { get; set; }

    [Required(ErrorMessage = "O Logradouro é obrigatório.")]
    [StringLength(250, ErrorMessage = "O Logradouro deve ter no máximo 15 caractéres.")]
    [MinLength(5, ErrorMessage = "O Logradouro deve ter pelo menos 10 caractéres.")]
    public string? Logradouro { get; set; }
    public int? Numero { get; set; }

    [StringLength(250, ErrorMessage = "O Complemento deve ter no máximo 15 caractéres.")]
    [MinLength(5, ErrorMessage = "O Complemento deve ter pelo menos 10 caractéres.")]
    public string? Complemento { get; set; }

    [StringLength(10, ErrorMessage = "O Cep deve ter no máximo 15 caractéres.")]
    [MinLength(8, ErrorMessage = "O Cep deve ter pelo menos 10 caractéres.")]
    public string? Cep { get; set; }

    public override string ToString()
    {
        return $"{nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Cep)}: {Cep}";
    }
}