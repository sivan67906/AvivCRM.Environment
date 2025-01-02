using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Applications.GetAllApplications;
public class GetAllApplicationQueryHandler : IRequestHandler<GetAllApplicationQuery, IEnumerable<ApplicationDTO>>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _appliRepository;
    public GetAllApplicationQueryHandler(IGenericRepository<Domain.Entities.Applications> repository) => _appliRepository = repository;

    public async Task<IEnumerable<ApplicationDTO>> Handle(GetAllApplicationQuery request, CancellationToken cancellationToken)
    {
        var applictions = await _appliRepository.GetAllAsync();

        var applicationlist = applictions.Select(x => new ApplicationDTO
        {
            Id = x.Id,
            DateFormat = x.DateFormat,
            TimeFormat = x.TimeFormat,
            DefaultTimezone = x.DefaultTimezone,
            CurrencyId = x.CurrencyId,
            CurrencyCode = x.Currency?.CurrencyCode,
            CurrencySymbol = x.Currency?.CurrencySymbol,
            Language = x.Language,
            DatatableRowLimit = x.DatatableRowLimit,
            EmployeeCanExportData = x.EmployeeCanExportData,
        }).ToList();

        return applicationlist;
    }
}
