using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.DeleteBusinessLocation;

internal class DeleteBusinessLocationCommandHandler : IRequestHandler<DeleteBusinessLocationCommand>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;

    public DeleteBusinessLocationCommandHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository) =>
        _businessLocationRepository = businessLocationRepository;
    public async System.Threading.Tasks.Task Handle(DeleteBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        await _businessLocationRepository.DeleteAsync(request.Id);
    }
}

