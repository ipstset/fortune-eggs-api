using FortuneEggs.Application.Fortunes.GetFortune;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FortuneEggs.Api.Fortunes;

[Route("fortunes")]
public class FortunesController(IMediator mediator) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<ActionResult> Get([FromRoute] Guid id)
    {
        var result = await mediator.Send(new GetFortuneRequest { Id = id });
        return Ok(result);
    }
    
}