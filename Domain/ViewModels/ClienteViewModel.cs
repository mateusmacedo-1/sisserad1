using System.Text.Json.Serialization;
using Domain.Enums;

namespace Domain.ViewModels;

public class ClienteViewModel
{
    public int? Id { get; set; }
    public string? Nome { get; set; }
    public string? Representante { get; set; }
    public string? Email { get; set; }
    public string? Telefone { get;  set; }
    public ICollection<EnderecoViewModel> Enderecos { get; set; } = [];


    private string? documento;
    public string? Documento 
    {
        get{ return documento; }
        set {
            documento = value;
            FormatarDocumento();
        } 
    }
    public string? DocumentoFormatado { get; set; }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public TipoCliente Tipo { get; set; }

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


    private void FormatarDocumento()
    {
        if (Tipo == TipoCliente.Física)
        {
            DocumentoFormatado = FormatarCPF(Documento);
        }

        else
        {
            DocumentoFormatado = FormatarCNPJ(Documento);
        }
    }
    static string FormatarCPF(string cpf)
    {
        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
    }

    static string FormatarCNPJ(string cnpj)
    {
        return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
    }
}