using System.ComponentModel.DataAnnotations;
using Domain.Enums;

namespace Domain.Models
{
    public sealed class Cliente

    {
        public Cliente()
        {
        }

        // Seu padrão de construtor com argumentos
        public Cliente(int? id, string? nome, string? email, string? telefone, TipoCliente? tipo, string? documento, string? representante)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Tipo = tipo;
            Documento = documento;
            Representante = representante;
        }
        
        public int? Id { get; private set; }

        [Required]
        [StringLength(250)]
        [MinLength(10)]
        public string? Nome { get; private set; }

        [Required]
        [StringLength(250)]
        [MinLength(10)]
        public string? Representante { get; private set; }

        [EmailAddress]
        [Required]
        [StringLength(250)]
        [MinLength(10)]
        public string? Email { get; private set; }

        [Required]
        [StringLength(20)]
        [MinLength(8)]
        public string? Telefone { get; private set; }

        public ICollection<Endereco> Enderecos { get; private set; } = new List<Endereco>();
        
        [Required]
        [StringLength(15)]
        [MinLength(10)]
        public string? Documento { get; private set; }

        [Required]
        [EnumDataType(typeof(TipoCliente))]
        public TipoCliente? Tipo { get; private set; }

        public override string ToString()
        {
            return $"{nameof(Nome)}: {Nome}, {nameof(Representante)}: {Representante}, {nameof(Documento)}: {Documento}, {nameof(Tipo)}: {Tipo}";
        }

        public void AtualizarDados(Cliente cliente)
        {
            if (cliente.Nome != null)
                Nome = cliente.Nome;
    
            if (cliente.Email != null)
                Email = cliente.Email;
    
            if (cliente.Telefone != null)
                Telefone = cliente.Telefone;
        }
    }
}