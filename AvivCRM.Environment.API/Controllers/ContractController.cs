﻿using AvivCRM.Environment.Application.Features.Contracts.CreateContract;
using AvivCRM.Environment.Application.Features.Contracts.DeleteContract;
using AvivCRM.Environment.Application.Features.Contracts.GetAllContract;
using AvivCRM.Environment.Application.Features.Contracts.GetContractById;
using AvivCRM.Environment.Application.Features.Contracts.UpdateContract;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ContractController : ControllerBase
{
    private readonly ISender _sender;
    public ContractController(ISender sender) => _sender = sender;


    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var product = await _sender.Send(new GetContractByIdQuery { Id = Id });
        if (product is not null) { return Ok(product); }
        return NotFound();
    }


    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateContractCommand command)
    {
        var id = await _sender.Send(command);
        return CreatedAtAction(nameof(GetById), new { id }, command);
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateContractCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var consumerList = await _sender.Send(new GetAllContractQuery());
        return Ok(consumerList);
    }


    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteContractCommand { Id = Id });
        return NoContent();
    }
}
