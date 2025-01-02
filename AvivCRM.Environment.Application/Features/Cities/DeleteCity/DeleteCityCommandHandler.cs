using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Cities.DeleteCity;

internal class DeleteCityCommandHandler : IRequestHandler<DeleteCityCommand>
{
    private readonly IGenericRepository<City> _cityRepository;

    public DeleteCityCommandHandler(
        IGenericRepository<City> cityRepository) =>
        _cityRepository = cityRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCityCommand request, CancellationToken cancellationToken)
    {
        await _cityRepository.DeleteAsync(request.Id);
    }
}

















