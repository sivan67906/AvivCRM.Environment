using MediatR;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Applications.CreateApplication;
public class CreateApplicationCommandHandler : IRequestHandler<CreateApplicationCommand, Guid>
{
    private readonly IGenericRepository<Domain.Entities.Applications> _applirepo;
    public CreateApplicationCommandHandler(IGenericRepository<Domain.Entities.Applications> applirepo) => _applirepo = applirepo;

    public async Task<Guid> Handle(CreateApplicationCommand request, CancellationToken cancellationToken)
    {
        var application = new Domain.Entities.Applications
        {
            DateFormat = request.DateFormat,
            TimeFormat = request.TimeFormat,
            DefaultTimezone = request.DefaultTimezone,
            CurrencyId = request.CurrencyId,
            Language = request.Language,
            DatatableRowLimit = request.DatatableRowLimit,
            EmployeeCanExportData = request.EmployeeCanExportData,

        };
        await _applirepo.CreateAsync(application);
        return application.Id;
    }
}
