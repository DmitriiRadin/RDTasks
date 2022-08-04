using RDTasks.Domain.Handlers.Tags;

namespace RDTasks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TagsController : ControllerBase
{
    private readonly IMediator _mediator;

    public TagsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUserTags()
    {
        var response = await _mediator.Send(new GetAllUserTags.Request());

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        var response = await _mediator.Send(new CreateTag.Request());

        return StatusCode(201, response);
    }
}