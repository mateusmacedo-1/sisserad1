using System.Text.Json.Serialization;
using Domain.Enums;
using Domain.Utils;

namespace Domain.ViewModels;

public class ClienteViewModel
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get;  set; }
    public ICollection<EnderecoViewModel> Enderecos { get; set; } = [];
    public string? Documento { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoCliente Tipo { get; init; }

    public bool SearchString(string? searchString){
        if (string.IsNullOrWhiteSpace(searchString))
            return true;
        if (Nome.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if (Representante.Contains(searchString, StringComparison.OrdinalIgnoreCase))
            return true;
        if ($"{Telefone} {Email} {Documento}".Contains(searchString))
            return true;
        return false;
    }
}