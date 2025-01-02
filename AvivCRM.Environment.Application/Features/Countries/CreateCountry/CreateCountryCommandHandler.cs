using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Countries.CreateCountry;

internal class CreateCountryCommandHandler(
    IGenericRepository<Country> countryRepository) : IRequestHandler<CreateCountryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCountryCommand request, CancellationToken cancellationToken)
    {
        var country = new Country
        {
            Code = request.Code,
            Name = request.Name,
            CreatedDate = request.CreatedDate,
            IsActive = request.IsActive
        };

        await countryRepository.CreateAsync(country);
    }
}













