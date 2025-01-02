using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Addresses.GetAddressById;

internal class GetAddressByIdQueryHandler : IRequestHandler<GetAddressByIdQuery, AddressDTO>
{
    private readonly IGenericRepository<AddressDTO> _addressRepository;

    public GetAddressByIdQueryHandler(
        IGenericRepository<AddressDTO> addressRepository) =>
        _addressRepository = addressRepository;

    public async Task<AddressDTO> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var address = await _addressRepository.GetByIdAsync(request.Id);
        if (address == null) return null;
        return new AddressDTO
        {
            Id = address.Id,
            Address1 = address.Address1,
            Address2 = address.Address2,
            ZipCode = address.ZipCode,
            Latitude = address.Latitude,
            Longitude = address.Longitude,
            IsPrimary = address.IsPrimary,
            CreatedDate = address.CreatedDate,
            IsActive = address.IsActive
        };
    }
}













