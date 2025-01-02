using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketChannels.UpdateTicketChannel;

internal class UpdateTicketChannelCommandHandler : IRequestHandler<UpdateTicketChannelCommand>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public UpdateTicketChannelCommandHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository) =>
        _ticketChannelRepository = ticketChannelRepository;

    public async System.Threading.Tasks.Task Handle(UpdateTicketChannelCommand request, CancellationToken cancellationToken)
    {
        var ticketChannel = new TicketChannel
        {
            Id = request.Id,
            TicketChannelCode = request.TicketChannelCode,
            TicketChannelName = request.TicketChannelName,
            UpdatedDate = DateTime.Now
        };

        await _ticketChannelRepository.UpdateAsync(ticketChannel);
    }
}








































