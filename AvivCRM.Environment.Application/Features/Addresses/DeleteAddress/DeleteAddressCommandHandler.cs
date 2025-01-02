using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Addresses.DeleteAddress;

internal class DeleteAddressCommandHandler : IRequestHandler<DeleteAddressCommand>
{
    private readonly IGenericRepository<Address> _addressRepository;

    public DeleteAddressCommandHandler(
        IGenericRepository<Address> addressRepository) =>
        _addressRepository = addressRepository;
    public async System.Threading.Tasks.Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken)
    {
        await _addressRepository.DeleteAsync(request.Id);
    }
}













