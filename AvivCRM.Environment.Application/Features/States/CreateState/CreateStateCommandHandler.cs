using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.States.CreateState;

internal class CreateStateCommandHandler(
    IGenericRepository<State> stateRepository) : IRequestHandler<CreateStateCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateStateCommand request, CancellationToken cancellationToken)
    {
        var state = new State
        {
            Code = request.Code,
            Name = request.Name,
            CountryId = request.CountryId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await stateRepository.CreateAsync(state);
    }
}













