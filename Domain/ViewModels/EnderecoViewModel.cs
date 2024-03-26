namespace Domain.ViewModels;

public class EnderecoViewModel
{
    public string? Logradouro { get; private set; }
    public int? Numero { get; private set; }
    public string? Complemento { get; private set; }
    public string? Cep { get; private set; }
}