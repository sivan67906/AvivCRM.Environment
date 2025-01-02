using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Application.Services;
using MediatR;

namespace AvivCRM.Environment.Application.Features.States.GetStatesByParentId;
public class GetStatesByParentIdQueryHandler : IRequestHandler<GetStatesByParentIdQuery, IEnumerable<StateDTO>>
{
    private readonly IStateService _stateService;

    public GetStatesByParentIdQueryHandler(IStateService stateService)
    {
        _stateService = stateService;
    }
    public async Task<IEnumerable<StateDTO>> Handle(GetStatesByParentIdQuery request, CancellationToken cancellationToken)
    {
        var states = await _stateService.GetStatesByParentId(request.CountryId);
        if (states == null || !states.Any()) return null;

        var consumers = states.Select(x => new StateDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            CountryId = x.CountryId,
            //CountryName = x.Countries.Name,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return consumers;
    }
}

