namespace Domain.Utils;

using System.ComponentModel.DataAnnotations;
using CpfCnpjLibrary;
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
    public static string FormatarCpfSemPonto(string documento)
    {
        return Cpf.FormatarSemPontuacao(documento);
    }

        public static string FormatarCnpjSemPonto(string documento)
    {
        return Cnpj.FormatarSemPontuacao(documento);
    }
}