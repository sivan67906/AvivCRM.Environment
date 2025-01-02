using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Addresses.GetAddressById
{
    public class GetAddressByIdQuery : IRequest<AddressDTO>
    {
        public Guid Id { get; set; }
    }
}













