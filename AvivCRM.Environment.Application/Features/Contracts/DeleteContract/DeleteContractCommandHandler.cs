using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Contracts.DeleteContract;
public class DeleteContractCommandHandler : IRequestHandler<DeleteContractCommand>
{
    private readonly IGenericRepository<Contract> _contractRepository;
    public DeleteContractCommandHandler(IGenericRepository<Contract> contractRepository) => _contractRepository = contractRepository;
    public async System.Threading.Tasks.Task Handle(DeleteContractCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _contractRepository.DeleteAsync(request.Id);
    }
}
