using MediatR;

namespace AvivCRM.Environment.Application.Features.Addresses.DeleteAddress
{
    public class DeleteAddressCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}













