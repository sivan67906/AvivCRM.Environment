using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Tasks.DeleteTask;
public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand>
{
    private readonly IGenericRepository<Task> _repository;
    public DeleteTaskCommandHandler(IGenericRepository<Task> repository)
    {
        _repository = repository;
    }

    public async Task Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
