using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Clients.GetAllClients;
public class GetAllClientsQuery : IRequest<IEnumerable<ClientDTO>>
{
}