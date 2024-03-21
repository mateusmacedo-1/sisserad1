namespace Application.InputModels;

public class EnderecoInputModel
{
    public int? Id { get; set;}
    public string? Logradouro { get;  set; }
    public int? Numero { get;  set; }
    public string? Cep { get;  set; }
    public string? Complemento { get;  set; }
}