using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Applications.DeleteApplication;
public class DeleteApplicationCommandHandler : IRequestHandler<DeleteApplicationCommand>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _appliRepo;

    public DeleteApplicationCommandHandler(IGenericRepository<Domain.Entities.Applications> repository) => _appliRepo = repository;

    public async Task Handle(DeleteApplicationCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _appliRepo.DeleteAsync(request.Id);
    }
}
