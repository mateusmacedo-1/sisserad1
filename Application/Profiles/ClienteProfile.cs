using Domain.ViewModels;
using AutoMapper;
using Domain.Enums;
using Domain.InputModels;
using Domain.Models;
using Domain.Utils;

namespace Application.Profiles;

public class ClienteProfile : Profile
{
    public ClienteProfile()
    {
        CreateMap<Cliente, ClienteDetailsViewModel>();
        CreateMap<Cliente, ClienteViewModel>()
            .ForMember(dest => dest.Documento, 
            opt => opt.MapFrom(src => DocumentoUtils.FormatarDocumento(src.Documento, src.Tipo)));
        CreateMap<CreateClienteInputModel, Cliente>();
    }
}