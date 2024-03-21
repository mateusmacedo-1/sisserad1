using Application.ViewModels;
using Domain.InputModels;


namespace Application.Services.Interfaces;

public interface IClienteService
{   
    Task<List<ClienteViewModel>> GetAll();
    ClienteDetailsViewModel? GetById(int id);
    Task<ClienteViewModel> Create(CreateClienteInputModel inputModel);
    Task<ClienteViewModel?> Update(UpdateClienteInputModel inputModel);
    void Delete(int id);
}