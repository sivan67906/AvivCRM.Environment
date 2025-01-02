using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketGroups.CreateTicketGroup;

internal class CreateTicketGroupCommandHandler(
    IGenericRepository<TicketGroup> ticketGroupRepository) : IRequestHandler<CreateTicketGroupCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateTicketGroupCommand request, CancellationToken cancellationToken)
    {
        var ticketGroup = new TicketGroup
        {
            TicketGroupCode = request.TicketGroupCode,
            TicketGroupName = request.TicketGroupName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await ticketGroupRepository.CreateAsync(ticketGroup);
    }
}








































