using MediatR;

namespace AvivCRM.Environment.Application.Features.Clients.DeleteClient;
public class DeleteClientCommand : IRequest
{
    public Guid Id { get; set; }
}
