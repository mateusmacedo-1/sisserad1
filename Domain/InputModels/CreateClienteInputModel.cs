using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.InputModels;

public class CreateClienteInputModel
{

    [Required]
    [StringLength(150, ErrorMessage = "O campo deve ter no máximo 150 caractéres.")]
    [MinLength(5, ErrorMessage = "O campo deve ter no mínimo 5 caractéres.")]
    public string? Nome { get;  set; }
    [Required]
    [StringLength(150, ErrorMessage = "O campo deve ter no máximo 150 caractéres.")]
    [MinLength(5, ErrorMessage = "O campo deve ter no mínimo 5 caractéres.")]
    public string? Representante { get;  set; }
    
    [EmailAddress]
    [Required]
    public string? Email { get;  set; }
    
    [Phone]
    [Required]
    public string? Telefone { get;  set; }

    [Required]
    public EnderecoInputModel Endereco { get; set; }
    
    [Required]
    public string? Documento { get;  set; }
    public TipoCliente Tipo { get;  set; }

}