using Domain.Models;

namespace Domain.Interfaces;

public interface IClienteRepository
{
    Task<IEnumerable<Cliente>> ObterClientes();
    Task<Cliente?> ObterCliente(int id);
    Task<Cliente> AdicionarCliente(Cliente cliente);
    Task DeletarCliente(int id);
    Task AtualizarCliente(Cliente cliente);
}