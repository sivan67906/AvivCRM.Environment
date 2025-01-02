using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.GetBusinessLocationById;

internal class GetBusinessLocationByIdQueryHandler : IRequestHandler<GetBusinessLocationByIdQuery, BusinessLocationDTO>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;

    public GetBusinessLocationByIdQueryHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository) =>
        _businessLocationRepository = businessLocationRepository;

    public async Task<BusinessLocationDTO> Handle(GetBusinessLocationByIdQuery request, CancellationToken cancellationToken)
    {
        var businessLocation = await _businessLocationRepository.GetByIdAsync(request.Id);
        if (businessLocation == null) return null;
        return new BusinessLocationDTO
        {
            Id = businessLocation.Id,
            Code = businessLocation.Code,
            Name = businessLocation.Name,
            CompanyId = businessLocation.CompanyId,
            AddressId = businessLocation.AddressId,
            Address1 = businessLocation.Address.Address1,
            Address2 = businessLocation.Address.Address2,
            ZipCode = businessLocation.Address.ZipCode,
            Latitude = businessLocation.Address.Latitude,
            Longitude = businessLocation.Address.Longitude,
            CountryId = businessLocation.CountryId,
            StateId = businessLocation.StateId,
            CityId = businessLocation.CityId,
            CountryName = businessLocation.Country.Name,
            StateName = businessLocation.State.Name,
            CityName = businessLocation.City.Name,
            TaxName = businessLocation.TaxName,
            TaxNumber = businessLocation.TaxNumber,
            IsActive = businessLocation.IsActive
        };
    }
}

