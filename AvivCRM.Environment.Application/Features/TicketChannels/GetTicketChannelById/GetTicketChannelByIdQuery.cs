//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.TicketChannels.GetTicketChannelById
{
    public class GetTicketChannelByIdQuery : IRequest<TicketChannelDTO>
    {
        public Guid Id { get; set; }
    }
}








































