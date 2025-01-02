using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.Languages.DeleteLanguage;
using AvivCRM.Environment.Application.Features.Languages.GetAllLanguages;
using AvivCRM.Environment.Application.Features.Languages.GetLanguageById;
using AvivCRM.Environment.Application.Features.Languages.CreateLanguage;
using AvivCRM.Environment.Application.Features.Languages.UpdateLanguage;

namespace AvivCRM.Environment.API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class LanguageController : ControllerBase
{
    private readonly ISender _sender;
    public LanguageController(ISender sender) => _sender = sender;

    [HttpGet("GetAll")]
    public async Task<IActionResult> GetAll()
    {
        var languageList = await _sender.Send(new GetAllLanguagesQuery());
        return Ok(languageList);
    }

    [HttpGet("GetById")]
    public async Task<IActionResult> GetById(Guid Id)
    {
        var language = await _sender.Send(new GetLanguageByIdQuery { Id = Id });
        if (language is not null) { return Ok(language); }
        return NotFound();
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateLanguageCommand command)
    {
        await _sender.Send(command);
        return Ok("Languages Created Successfully.");
    }

    [HttpPut("Update")]
    public async Task<IActionResult> Update(UpdateLanguageCommand command)
    {
        await _sender.Send(command);
        return NoContent();
    }

    [HttpDelete("Delete")]
    public async Task<IActionResult> Delete(Guid Id)
    {
        await _sender.Send(new DeleteLanguageCommand { Id = Id });
        return NoContent();
    }
}


















