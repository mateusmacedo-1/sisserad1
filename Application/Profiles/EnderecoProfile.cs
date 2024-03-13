using Application.InputModels;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;

namespace Application.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<Endereco, EnderecoViewModel>()
            .ReverseMap();
        CreateMap<EnderecoInputModel, Endereco>();
    }
}