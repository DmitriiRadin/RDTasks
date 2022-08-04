namespace RDTasks.Domain.Handlers.Projects;

public static class CreateProject
{
    public record Request : IRequest<Response>;
    
    public record Response;

    public class Handler : IRequestHandler<Request, Response>
    {
        public Task<Response> Handle(Request request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new Response());
        }
    }
}