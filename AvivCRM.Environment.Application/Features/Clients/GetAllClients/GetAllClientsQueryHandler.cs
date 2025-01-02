using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Clients.GetAllClients;
public class GetAllClientsQueryHandler : IRequestHandler<GetAllClientsQuery, IEnumerable<ClientDTO>>
{
    private readonly IGenericRepository<Domain.Entities.Client> _repository;
    public GetAllClientsQueryHandler(IGenericRepository<Domain.Entities.Client> repository) => _repository = repository;

    public async Task<IEnumerable<ClientDTO>> Handle(GetAllClientsQuery request, CancellationToken cancellationToken)
    {
        var clients = await _repository.GetAllAsync();

        var clientlist = clients.Select(x => new ClientDTO
        {
            Id = x.Id,
            ClientName = x.ClientName,
            ClientCode = x.ClientCode,
            Description = x.Description,
            Email = x.Email,
            PhoneNumber = x.PhoneNumber,
            CompanyId = x.CompanyId,
            CompanyName = x.Company.Name,
            AddressId = x.AddressId,
            Address1 = x.Address.Address1,
            Address2 = x.Address.Address2,
            ZipCode = x.Address.ZipCode,
            CountryId = x.CountryId,
            StateId = x.StateId,
            CityId = x.CityId,
            CountryName = x.Country.Name,
            StateName = x.State.Name,
            CityName = x.City.Name,
        }).ToList();

        return clientlist;
    }
}