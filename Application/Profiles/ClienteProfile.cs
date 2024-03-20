using Application.InputModels;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, ClienteDetailsViewModel>();
        CreateMap<Cliente, ClienteViewModel>();
        CreateMap<CreateClienteInputModel, Cliente>();
    }
}