using System.ComponentModel.DataAnnotations;
using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using FluentValidation;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;
using ValidationException = System.ComponentModel.DataAnnotations.ValidationException;

namespace Application.Services;

public class EnderecoService(IMapper mapper, SeradDbContext context, AbstractValidator<Endereco> validator) : IEnderecoService
{
    
    private readonly SeradDbContext _context = context;
    private readonly AbstractValidator<Endereco> _validator = validator;
    private readonly IMapper _mapper = mapper;
    

    public async Task<List<EnderecoViewModel>> GetAllByClient(int clientId)
    {
        var enderecos = await _context.Enderecos
            .Where(e => e.ClienteId == clientId)
            .ToListAsync();
        var viewModels = _mapper.Map<List<EnderecoViewModel>>(enderecos);
        return viewModels;
    }
    public EnderecoViewModel? GetById(int id)
    {
        var endereco = _context.Enderecos
            .SingleOrDefault(u => u.Id == id);
        if (endereco == null) return new EnderecoViewModel();
        var detailsViewModel = _mapper.Map<EnderecoViewModel>(endereco);
        return detailsViewModel;

    }

    public async Task<EnderecoViewModel> Create(EnderecoInputModel inputModel, int clienteId)
    {
        var endereco = _mapper.Map<Endereco>(inputModel);
        endereco.ClienteId = clienteId;
        Validate(endereco, _validator);
        var criado = _context.Enderecos.Add(endereco);
        await _context.SaveChangesAsync();
        return _mapper.Map<EnderecoViewModel>(criado.Entity);
    }

    public async Task<EnderecoViewModel?> Update(EnderecoInputModel inputModel, int clienteId)
    {
        var endereco = await _context.Enderecos
            .Where(e => e.ClienteId == clienteId)
            .SingleOrDefaultAsync(p => p.Id == inputModel.Id);
        if (endereco == null) return null;
        var enderecoEntrada = _mapper.Map<Endereco>(inputModel);
        Validate(enderecoEntrada, _validator);
        endereco.AtualizarDados(enderecoEntrada);
        var viewModel = _mapper.Map<EnderecoViewModel>(endereco);
        return viewModel;
    }
    
    public void Delete(int id)
    {
        var cliente = _context.Clientes.SingleOrDefault(u => u.Id == id) ?? throw new DbUpdateException("Usuário não encontrado");
        _context.Clientes.Remove(cliente);
    }

    private static void Validate(Endereco cliente, IValidator<Endereco> validator)
    {
        if (cliente == null)
            throw new Exception("Registro não detectado!");
        
        ValidateBusiness(cliente, validator);
        ValidateModel(cliente);
    }

    private static void ValidateBusiness(Endereco cliente, IValidator<Endereco> validator)
    {
        validator.ValidateAndThrow(cliente);
    }

    private static void ValidateModel(Endereco endereco)
    {
        var validationContext = new ValidationContext(endereco);
        var validationResults = new List<ValidationResult>();
        var isValid = Validator.TryValidateObject(endereco, validationContext, validationResults, true);
        if (!isValid)
        {
            var errorText = string.Empty;
            validationResults.ForEach(r => errorText += r.ErrorMessage);
            throw new ValidationException(errorText);
        }
    }

}