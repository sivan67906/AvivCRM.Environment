using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.DeleteBusinessType;

internal class DeleteBusinessTypeCommandHandler : IRequestHandler<DeleteBusinessTypeCommand>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public DeleteBusinessTypeCommandHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;
    public async System.Threading.Tasks.Task Handle(DeleteBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        await _businessTypeRepository.DeleteAsync(request.Id);
    }
}






