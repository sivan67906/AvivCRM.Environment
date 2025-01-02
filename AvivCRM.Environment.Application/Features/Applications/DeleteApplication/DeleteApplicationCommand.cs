using MediatR;

namespace AvivCRM.Environment.Application.Features.Applications.DeleteApplication;
public class DeleteApplicationCommand : IRequest
{
    public Guid Id { get; set; }
}
