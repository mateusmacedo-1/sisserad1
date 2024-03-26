namespace Domain.Utils;

using System.ComponentModel.DataAnnotations;
using CpfCnpjLibrary;
using Domain.Enums;
using Domain.Models;

public class DocumentoUtils
{

    public DocumentoUtils()
    {
        
    }

    public static bool ValidarCpf(string cpf)
    {
        return Cpf.Validar(cpf);
    }

    public static bool ValidarCnpj(string cnpj)
    {
        return Cnpj.Validar(cnpj);
    }

    public static string RemoverPontuacaoDocumento(Cliente cliente)
    {
        if(cliente.Tipo == Enums.TipoCliente.Física)
            return Cpf.FormatarSemPontuacao(cliente.Documento);
        else if(cliente.Tipo == Enums.TipoCliente.Jurídica) 
            return Cnpj.FormatarSemPontuacao(cliente.Documento);
        else 
        {
            throw new ValidationException("Não foi possível validar o documento.");
        }
    }
    private static string FormatarCpfSemPonto(string documento)
    {
        return Cpf.FormatarSemPontuacao(documento);
    }

    private static string FormatarCnpjSemPonto(string documento)
    {
        return Cnpj.FormatarSemPontuacao(documento);
    }

    static private string FormatarCPF(string cpf)
    {
        return Convert.ToUInt64(cpf).ToString(@"000\.000\.000\-00");
    }

    static private string FormatarCNPJ(string cnpj)
    {
        return Convert.ToUInt64(cnpj).ToString(@"00\.000\.000\/0000\-00");
    }

    static public string FormatarDocumento(string? documento, TipoCliente? tipo)
    {   
        return tipo switch
        {
            TipoCliente.Física => FormatarCPF(documento ?? ""),
            TipoCliente.Jurídica => FormatarCNPJ(documento ?? ""),
            _ => throw new Exception($" {tipo}: Tipo não reconhecido."),
        };
    }
}