using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.States.DeleteState;

internal class DeleteStateCommandHandler : IRequestHandler<DeleteStateCommand>
{
    private readonly IGenericRepository<State> _stateRepository;

    public DeleteStateCommandHandler(
        IGenericRepository<State> stateRepository) =>
        _stateRepository = stateRepository;
    public async System.Threading.Tasks.Task Handle(DeleteStateCommand request, CancellationToken cancellationToken)
    {
        await _stateRepository.DeleteAsync(request.Id);
    }
}













