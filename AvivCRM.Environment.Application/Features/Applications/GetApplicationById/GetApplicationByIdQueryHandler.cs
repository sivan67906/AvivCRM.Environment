using Azure.Core;
using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Applications.GetApplicationById;
public class GetApplicationByIdQueryHandler : IRequestHandler<GetApplicationByIdQuery, ApplicationDTO>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _entitiesRepository;
    public GetApplicationByIdQueryHandler(IGenericRepository<Domain.Entities.Applications> repository) => _entitiesRepository = repository;

    public async Task<ApplicationDTO> Handle(GetApplicationByIdQuery request, CancellationToken cancellationToken)
    {
        var application = await _entitiesRepository.GetByIdAsync(request.Id);
        if (application == null) return null;
        return new ApplicationDTO
        {
            Id = application.Id,
            DateFormat = application.DateFormat,
            TimeFormat = application.TimeFormat,
            DefaultTimezone = application.DefaultTimezone,
            CurrencyId = application.CurrencyId,
            CurrencyCode = application.Currency.CurrencyCode,
            CurrencySymbol = application.Currency.CurrencySymbol,
            Language = application.Language,
            DatatableRowLimit = application.DatatableRowLimit,
            EmployeeCanExportData = application.EmployeeCanExportData,
        };
    }
}
