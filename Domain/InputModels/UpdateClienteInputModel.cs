using Domain.Enums;

namespace Domain.InputModels;

public class UpdateClienteInputModel
{

    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public string? Email { get; set; }
    public string? Documento { get; set; }
    public TipoCliente Tipo { get; set; }

}