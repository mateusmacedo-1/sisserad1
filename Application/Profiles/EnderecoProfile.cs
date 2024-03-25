
using Domain.ViewModels;
using AutoMapper;
using Domain.InputModels;
using Domain.Models;

namespace Application.Profiles;

public class EnderecoProfile : Profile
{
    public EnderecoProfile()
    {
        CreateMap<Endereco, EnderecoViewModel>()
            .ReverseMap();
        CreateMap<EnderecoInputModel, Endereco>();
        CreateMap<EnderecoInputModel, List<Endereco>>()
            .ConvertUsing(src => new List<Endereco> {
                    new() {Cep = src.Cep, Complemento = src.Complemento, Logradouro = src.Logradouro, Numero = src.Numero, Id = src.Numero}
                });
    }
}