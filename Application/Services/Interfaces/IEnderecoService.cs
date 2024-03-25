
using Domain.ViewModels;
using Domain.InputModels;

namespace Application.Services.Interfaces;

public interface IEnderecoService
{   
    Task<List<EnderecoViewModel>> GetAllByClient(int clientId);
    EnderecoViewModel? GetById(int id);
    Task<EnderecoViewModel?> Create(EnderecoInputModel inputModel, int clienteId);
    Task<EnderecoViewModel?> Update(EnderecoInputModel inputModel, int clienteId);
    void Delete(int id);
}