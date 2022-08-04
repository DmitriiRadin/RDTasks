using RDTasks.Domain.Handlers.Projects;

namespace RDTasks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class ProjectsController : ControllerBase
{
    private readonly IMediator _mediator;

    public ProjectsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUserTags()
    {
        var response = await _mediator.Send(new GetAllUserProjects.Request());

        return Ok(response);
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        var response = await _mediator.Send(new CreateProject.Request());

        return StatusCode(201, response);
    }
}