using Application.InputModels;
using Application.ViewModels;
using Domain.Models;
using FluentValidation;

namespace Application.Services.Interfaces;

public interface IClienteService
{   
    Task<List<ClienteViewModel>> GetAll();
    ClienteDetailsViewModel? GetById(int id);
    Task<ClienteViewModel> Create(CreateClienteInputModel inputModel);
    Task<ClienteViewModel?> Update(UpdateClienteInputModel inputModel);
    void Delete(int id);
    void Validate(Cliente client, AbstractValidator<Cliente> validator);
}