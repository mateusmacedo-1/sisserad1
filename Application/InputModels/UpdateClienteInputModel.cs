using Application.ViewModels;
using Domain.Enums;

namespace Application.InputModels;

public class UpdateClienteInputModel
{

    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public ICollection<EnderecoInputModel> Enderecos { get; set; } = [];
    public string? Email { get; set; }
    public string? Documento { get; set; }
    public TipoCliente Tipo { get; set; }

}