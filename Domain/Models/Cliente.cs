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
        public Cliente(int id, string? nome, string? email, string? telefone, TipoCliente? tipo, string? documento, string? representante)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Tipo = tipo;
            Documento = documento;
            Representante = representante;
        }
        
        
        public int Id { get; private set; }

        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(250, ErrorMessage = "O nome deve ter no máximo 250 caractéres.")]
        [MinLength(10, ErrorMessage = "O nome deve ter pelo menos 10 caractéres.")]
        public string? Nome { get; private set; }

        [Required(ErrorMessage = "O nome do representante é obrigatório.")]
        [StringLength(250, ErrorMessage = "O nome do representante deve ter no máximo 250 caractéres.")]
        [MinLength(10, ErrorMessage = "O nome do representante deve ter pelo menos 10 caractéres.")]
        public string? Representante { get; private set; }

        [EmailAddress]
        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [StringLength(250, ErrorMessage = "O e-mail deve ter no máximo 250 caractéres.")]
        [MinLength(10, ErrorMessage = "O e-mail deve ter pelo menos 10 caractéres.")]
        public string? Email { get; private set; }

        [Required(ErrorMessage = "O Telefone é obrigatório.")]
        [StringLength(20, ErrorMessage = "O Telefone deve ter no máximo 20 caractéres.")]
        [MinLength(8, ErrorMessage = "O Telefone deve ter pelo menos 8 caractéres.")]
        public string? Telefone { get; private set; }

        public ICollection<Endereco> Enderecos { get; private set; } = [];
        
        [Required(ErrorMessage = "O Documento é obrigatório.")]
        [StringLength(15, ErrorMessage = "O Documento deve ter no máximo 15 caractéres.")]
        [MinLength(10, ErrorMessage = "O Documento deve ter pelo menos 10 caractéres.")]
        public string? Documento { get; set; }

        [Required(ErrorMessage = "O Tipo do Cliente é obrigatório.")]
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

            if (cliente.Representante != null)
                Representante = cliente.Representante;
        }
    }
}