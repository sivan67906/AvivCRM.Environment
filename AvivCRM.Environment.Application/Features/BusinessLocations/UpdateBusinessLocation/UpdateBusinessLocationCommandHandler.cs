using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.UpdateBusinessLocation;

internal class UpdateBusinessLocationCommandHandler : IRequestHandler<UpdateBusinessLocationCommand>
{
    private readonly IGenericRepository<BusinessLocation> _businessLocationRepository;
    private readonly IGenericRepository<Address> _addressRepository;

    public UpdateBusinessLocationCommandHandler(
        IGenericRepository<BusinessLocation> businessLocationRepository,
        IGenericRepository<Address> addressRepository)
    {
        _businessLocationRepository = businessLocationRepository;
        _addressRepository = addressRepository;
    }

    public async System.Threading.Tasks.Task Handle(UpdateBusinessLocationCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Id = request.AddressId,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            CityId = request.CityId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
        var updatedAddress = await _addressRepository.UpdateAsyncwithEntity(address);

        var businessLocation = new BusinessLocation
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            CompanyId = request.CompanyId,
            AddressId = updatedAddress.Id,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,
            TaxName = request.TaxName,
            TaxNumber = request.TaxNumber,
            CreatedDate = DateTime.Now,
            IsActive = request.IsActive
        };
        await _businessLocationRepository.UpdateAsync(businessLocation);
    }
}

