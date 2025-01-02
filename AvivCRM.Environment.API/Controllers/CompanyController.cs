using AvivCRM.Environment.Application.Features.Companies.CreateCompany;
using AvivCRM.Environment.Application.Features.Companies.DeleteCompany;
using AvivCRM.Environment.Application.Features.Companies.GetAllCompanies;
using AvivCRM.Environment.Application.Features.Companies.GetCompanyById;
using AvivCRM.Environment.Application.Features.Companies.UpdateCompany;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CompanyController : ControllerBase
{
    private readonly ISender _sender;
    public CompanyController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var companyList = await _sender.Send(new GetAllCompaniesQuery());
        return Ok(companyList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var company = await _sender.Send(new GetCompanyByIdQuery { Id = Id });
        if (company is not null) { return Ok(company); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateCompanyCommand command)
    {
        await _sender.Send(command);
        return Ok("Companies Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateCompanyCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteCompanyCommand { Id = Id });
        return NoContent();
    }
}


