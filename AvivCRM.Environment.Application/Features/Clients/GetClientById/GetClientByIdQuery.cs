using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Clients.GetClientById;
public class GetClientByIdQuery : IRequest<ClientDTO>
{
    public Guid Id { get; set; }
}