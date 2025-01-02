using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.TicketChannels.GetAllTicketChannels;

internal class GetAllTicketChannelsQueryHandler : IRequestHandler<GetAllTicketChannelsQuery, IEnumerable<TicketChannelDTO>>
{
    private readonly IGenericRepository<TicketChannel> _ticketChannelRepository;

    public GetAllTicketChannelsQueryHandler(
        IGenericRepository<TicketChannel> ticketChannelRepository)
    {
        _ticketChannelRepository = ticketChannelRepository;
    }

    public async Task<IEnumerable<TicketChannelDTO>> Handle(GetAllTicketChannelsQuery request, CancellationToken cancellationToken)
    {
        var ticketChannels = await _ticketChannelRepository.GetAllAsync();
        var ticketChannelList = ticketChannels.Select(x => new TicketChannelDTO
        {
            Id = x.Id,
            TicketChannelCode = x.TicketChannelCode,
            TicketChannelName = x.TicketChannelName
        }).ToList();

        return ticketChannelList;
    }
}








































