using System.ComponentModel.DataAnnotations;
using Application.InputModels;
using Application.Services.Interfaces;
using Application.ViewModels;
using AutoMapper;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API;

[Route("api/[controller]")]
[ApiController]
public class ClientesController(IMapper mapper, IClienteService service, IEnderecoService enderecoService) : ControllerBase
{
    private readonly IClienteService _service = service;
    private readonly IEnderecoService _enderecoService = enderecoService;
    private readonly IMapper _mapper = mapper;

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ClienteViewModel>>> GetClientes()
    {
        var clientes = await _service.GetAll();
        return Ok(clientes);
    }

    [HttpGet("{id:int}")]
    public  ActionResult<ClienteDetailsViewModel> GetCliente(int id)
    {
        var cliente = _service.GetById(id);
        if (cliente?.Nome == null) return NotFound("Cliente não encontrado");
        var viewModel = _mapper.Map<ClienteDetailsViewModel>(cliente);
        return Ok(viewModel);
    }
    
    [HttpPost]
    public async Task<ActionResult<ClienteViewModel>> CreateCliente([FromBody] CreateClienteInputModel cliente)
    {
        try{
            var criado = await _service.Create(cliente);
            var uri = Url.Action("GetCliente");
            return Created(uri, new {Id = criado.Id});
        } catch (Exception e) when (e is ValidationException || e is FluentValidation.ValidationException){
            return BadRequest(e.Message);
        }
        
    }

    [HttpPut]
    public async Task<ActionResult<ClienteViewModel>> UpdateCliente(UpdateClienteInputModel updateClienteInputModel)
    {
        var atualizado =  await _service.Update(updateClienteInputModel);
        if (atualizado == null) return NotFound("Cliente não encontrado");
        return Ok(atualizado);
    }
    
    [HttpDelete("{id:int}")]
    public ActionResult DeleteCliente(int id)
    {
        try
        {
            _service.Delete(id);
            return Ok("Cliente deletado.");
        }
        catch (DbUpdateException e)
        {
            return NotFound(e.Message);
        }
        
    }
    
    

    
}