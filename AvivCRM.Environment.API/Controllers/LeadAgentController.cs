using MediatR;
using Microsoft.AspNetCore.Mvc;
using AvivCRM.Environment.Application.Features.LeadAgents.CreateLeadAgent;

namespace AvivCRM.Environment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadAgentController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeadAgentController(IMediator mediator) => _mediator = mediator;

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CreateLeadAgentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
            //return CreatedAtAction(nameof(GetById), new { id }, command);
        }

        //[HttpGet("GetById")]
        //public async Task<IActionResult> GetById(int Id)
        //{
        //    var product = await _mediator.Send(new GetLeadAgentsByIdQuery { Id = Id });
        //    if (product is not null) { return Ok(product); }
        //    return NotFound();
        //}


        //[HttpPost("Create")]
        //public async Task<IActionResult> Create(CreateLeadAgentCommand command)
        //{
        //    var result = await _mediator.Send(command);
        //    return Ok(result);
        //    //return CreatedAtAction(nameof(GetById), new { id }, command);
        //}

        //[HttpPut("Update")]
        //public async Task<IActionResult> Update(UpdateLeadAgentCommand command)
        //{
        //    await _mediator.Send(command);
        //    return NoContent();
        //}

        //[HttpGet("GetAll")]
        //public async Task<IActionResult> GetAll()
        //{
        //    var consumerList = await _mediator.Send(new GetAllLeadAgentsQuery());
        //    return Ok(consumerList);
        //}


        //[HttpDelete("Delete")]
        //public async Task<IActionResult> Delete(int Id)
        //{
        //    await _mediator.Send(new DeleteLeadAgentCommand { Id = Id });
        //    return NoContent();
        //}
    }
}
