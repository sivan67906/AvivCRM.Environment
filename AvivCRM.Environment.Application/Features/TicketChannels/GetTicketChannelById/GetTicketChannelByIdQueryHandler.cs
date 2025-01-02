using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketChannels.GetTicketChannelById;

internal class GetTicketChannelByIdQueryHandler : IRequestHandler<GetTicketChannelByIdQuery, TicketChannelDTO>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public GetTicketChannelByIdQueryHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository) =>
        _ticketChannelRepository = ticketChannelRepository;

    public async Task<TicketChannelDTO> Handle(GetTicketChannelByIdQuery request, CancellationToken cancellationToken)
    {
        var ticketChannel = await _ticketChannelRepository.GetByIdAsync(request.Id);
        if (ticketChannel == null) return null;
        return new TicketChannelDTO
        {
            Id = ticketChannel.Id,
            TicketChannelCode = ticketChannel.TicketChannelCode,
            TicketChannelName = ticketChannel.TicketChannelName
        };
    }
}








































