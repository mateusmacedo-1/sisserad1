using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using Infra.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Services;

public class ClienteService(IMapper mapper, SeradDbContext context) : IClienteService
{
    
    private readonly SeradDbContext _context = context;
    private readonly IMapper _mapper = mapper;
    
    public async Task<List<ClienteViewModel>> GetAll()
    {
        var clientes = await _context.Clientes
            .Include(c => c.Enderecos)
            .ToListAsync();
        var viewModels = _mapper.Map<List<ClienteViewModel>>(clientes);
        return viewModels;
    }

    public ClienteDetailsViewModel? GetById(int id)
    {
        var cliente = _context.Clientes
            .Include(u => u.Enderecos)
            .SingleOrDefault(u => u.Id == id);
        if (cliente == null) return new ClienteDetailsViewModel();
        var detailsViewModel = _mapper.Map<ClienteDetailsViewModel>(cliente);
        return detailsViewModel;

    }

    public async Task<ClienteViewModel> Create(CreateClienteInputModel inputModel)
    {
        var cliente = _mapper.Map<Cliente>(inputModel);
        var criado = _context.Clientes.Add(cliente);
        await _context.SaveChangesAsync();
        return _mapper.Map<ClienteViewModel>(criado.Entity);
    }

    public async Task<ClienteViewModel?> Update(UpdateClienteInputModel inputModel)
    {
        var cliente = await _context.Clientes.SingleOrDefaultAsync(p => p.Id == inputModel.Id);
        if (cliente == null) return null;
        cliente.AtualizarDados(_mapper.Map<Cliente>(inputModel));
        var viewModel = _mapper.Map<ClienteViewModel>(cliente);
        return viewModel;
    }
    
    public void Delete(int id)
    {
        var cliente = _context.Clientes.SingleOrDefault(u => u.Id == id) ?? throw new DbUpdateException("Usuário não encontrado");
        _context.Clientes.Remove(cliente);
    }
}