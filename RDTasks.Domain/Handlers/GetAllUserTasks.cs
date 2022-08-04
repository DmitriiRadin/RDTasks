namespace RDTasks.Domain.Handlers;

public class GetAllUserTasks
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