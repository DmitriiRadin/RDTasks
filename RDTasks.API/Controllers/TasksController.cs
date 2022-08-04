namespace RDTasks.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TasksController : ControllerBase
{
    private readonly IMediator _mediator;

    public TasksController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAllUserTasks()
    {
        var response = await _mediator.Send(new GetAllUserTasks.Request());
        return Ok(response);
    }
}