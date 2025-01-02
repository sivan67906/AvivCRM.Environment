using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Messages.DeleteMessage;
public class DeleteMessageCommandHandler : IRequestHandler<DeleteMessageCommand>
{
    private readonly IGenericRepository<Message> _repository;
    public DeleteMessageCommandHandler(IGenericRepository<Message> repository) => _repository = repository;

    public async System.Threading.Tasks.Task Handle(DeleteMessageCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _repository.DeleteAsync(request.Id);
    }
}
