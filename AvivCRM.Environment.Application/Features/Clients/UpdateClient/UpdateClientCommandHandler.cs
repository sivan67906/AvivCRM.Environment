using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Clients.UpdateClient;
public class UpdateClientCommandHandler : IRequestHandler<UpdateClientCommand, Guid>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    private readonly IGenericRepository<Address> _addressRepository;
    public UpdateClientCommandHandler(IGenericRepository<Domain.Entities.Client> repository, IGenericRepository<Address> addressRepository)
    {
        _repository = repository;
        _addressRepository = addressRepository;
    }
    public async Task<Guid> Handle(UpdateClientCommand request, CancellationToken cancellationToken)
    {
        var address = new Address
        {
            Id = request.Id,
            Address1 = request.Address1,
            Address2 = request.Address2,
            ZipCode = request.ZipCode,
            CityId = request.CityId,
            CreatedDate = DateTime.Now,
            IsActive = true
        };
        var insertedAddress = await _addressRepository.UpdateAsyncwithEntity(address);
        var product = new Domain.Entities.Client
        {
            Id = request.Id,
            ClientName = request.ClientName,
            ClientCode = request.ClientCode,
            Description = request.Description,
            Email = request.Email,
            CompanyId = request.CompanyId,
            PhoneNumber = request.PhoneNumber,
            AddressId = request.AddressId,
            CountryId = request.CountryId,
            StateId = request.StateId,
            CityId = request.CityId,

        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}