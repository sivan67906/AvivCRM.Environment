using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Cities.CreateCity;

internal class CreateCityCommandHandler(
    IGenericRepository<City> cityRepository) : IRequestHandler<CreateCityCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCityCommand request, CancellationToken cancellationToken)
    {
        var city = new City
        {
            Code = request.Code,
            Name = request.Name,
            StateId = request.StateId,
            CreatedDate = DateTime.UtcNow,
            IsActive = true
        };

        await cityRepository.CreateAsync(city);
    }
}

















