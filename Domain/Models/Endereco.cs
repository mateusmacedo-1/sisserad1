namespace Domain.Models;

public class Endereco
{
    public Endereco()
    {
        
    }
    public int? Id { get; set; }
    public string? Logradouro { get; set; }
    public int? Numero { get; set; }
    public string? Complemento { get; set; }
    public string? Cep { get; set; }

    public override string ToString()
    {
        return $"{nameof(Logradouro)}: {Logradouro}, {nameof(Numero)}: {Numero}, {nameof(Complemento)}: {Complemento}, {nameof(Cep)}: {Cep}";
    }
}