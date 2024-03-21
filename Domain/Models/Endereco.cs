using System.ComponentModel.DataAnnotations;

namespace Domain.Models;

public class Endereco
{
    public Endereco()
    {
        
    }
    public int? Id { get; set; }

    [Required(ErrorMessage = "O Logradouro é obrigatório.")]
    [StringLength(250, ErrorMessage = "O Logradouro deve ter no máximo 250 caractéres.")]
    [MinLength(5, ErrorMessage = "O Logradouro deve ter pelo menos 10 caractéres.")]
    public string? Logradouro { get; set; }
    [Required(ErrorMessage = "O Número é obrigatório.")]
    public int? Numero { get; set; }

    [StringLength(250, ErrorMessage = "O Complemento deve ter no máximo 250 caractéres.")]
    [MinLength(5, ErrorMessage = "O Complemento deve ter pelo menos 10 caractéres.")]
    public string? Complemento { get; set; }

    [StringLength(10, ErrorMessage = "O Cep deve ter no máximo 10 caractéres.")]
    [MinLength(8, ErrorMessage = "O Cep deve ter pelo menos 8 caractéres.")]
    public string? Cep { get; set; }


    [Required(ErrorMessage = "O endereço precisa estar associado a um cliente.")]
    public int ClienteId { get; set; }
    public Cliente Cliente { get; set;}

    public void AtualizarDados(Endereco enderecoEntrada)
    {

        if (enderecoEntrada.Logradouro != null)
            Logradouro = enderecoEntrada.Logradouro;

        if (enderecoEntrada.Numero != null)
            Numero = enderecoEntrada.Numero;

        if (enderecoEntrada.Complemento != null)
            Complemento = enderecoEntrada.Complemento;

        if (enderecoEntrada.Cep != null)
            Cep = enderecoEntrada.Cep;

    }

    public override string ToString()
    {
        return $"{nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Cep)}: {Cep}";
    }
}