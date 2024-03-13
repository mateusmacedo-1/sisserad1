using Application.InputModels;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<ClienteDetailsViewModel, Cliente>()
            .ReverseMap();
        CreateMap<ClienteViewModel, Cliente>()
            .ForMember(c => c.Tipo, 
                opt => opt.MapFrom(src => src.Tipo.ToString()))
            .ReverseMap();
        CreateMap<CreateClienteInputModel, Cliente>()
            .ReverseMap();
    }
}