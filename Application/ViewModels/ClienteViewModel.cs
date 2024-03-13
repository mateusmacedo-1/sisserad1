using Domain.Enums;

namespace Application.ViewModels;

public class ClienteViewModel
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get;  set; }
    public ICollection<EnderecoViewModel> Enderecos { get; set; } = [];
    public string? Documento { get; set; }
    public string Tipo { get; set; }
}