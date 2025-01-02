using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Designations.DeleteDesignation;

internal class DeleteDesignationCommandHandler : IRequestHandler<DeleteDesignationCommand>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public DeleteDesignationCommandHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;
    public async System.Threading.Tasks.Task Handle(DeleteDesignationCommand request, CancellationToken cancellationToken)
    {
        await _designationRepository.DeleteAsync(request.Id);
    }
}






