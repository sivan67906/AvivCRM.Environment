using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Clients.GetClientById;
public class GetClientByIdQueryHandler : IRequestHandler<GetClientByIdQuery, ClientDTO>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    public GetClientByIdQueryHandler(IGenericRepository<Domain.Entities.Client> repository) => _repository = repository;

    public async Task<ClientDTO> Handle(GetClientByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _repository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new ClientDTO
        {
            Id = client.Id,
            ClientName = client.ClientName,
            ClientCode = client.ClientCode,
            Description = client.Description,
            Email = client.Email,
            PhoneNumber = client.PhoneNumber,
            CompanyId = client.CompanyId,
            CompanyName = client.Company.Name,
            AddressId = client.AddressId,
            Address1 = client.Address.Address1,
            Address2 = client.Address.Address2,
            ZipCode = client.Address.ZipCode,
            CountryId = client.CountryId,
            StateId = client.StateId,
            CityId = client.CityId,
            CountryName = client.Country.Name,
            StateName = client.State.Name,
            CityName = client.City.Name,
        };
    }
}