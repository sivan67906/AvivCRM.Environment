using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Addresses.CreateAddress;

internal class CreateAddressCommandHandler(
    IGenericRepository<Address> addressRepository) : IRequestHandler<CreateAddressCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateAddressCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            Latitude = request.Latitude,
            Longitude = request.Longitude,
            CityId = request.CityId,
            IsPrimary = request.IsPrimary,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await addressRepository.CreateAsync(address);
    }
}













