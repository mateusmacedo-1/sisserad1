using Domain.Enums;
using Domain.Models;

namespace Application.ViewModels;

public class ClienteDetailsViewModel
{
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get; set; }
    public ICollection<EnderecoViewModel> Enderecos { get; set; } = [];
    public string? Documento { get; set; }
    public TipoCliente Tipo { get; set; }
}