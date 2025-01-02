using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Messages.GetMessageById;
public class GetMessageByIdQueryHandler : IRequestHandler<GetMessageByIdQuery, MessageDTO>
{
    private readonly IGenericRepository<Message> _messageRepository;
    public GetMessageByIdQueryHandler(IGenericRepository<Message> messageRepository)
    {
        _messageRepository = messageRepository;
    }

    public async Task<MessageDTO> Handle(GetMessageByIdQuery request, CancellationToken cancellationToken)
    {
        var client = await _messageRepository.GetByIdAsync(request.Id);
        if (client == null) return null;
        return new MessageDTO
        {
            Id = client.Id,
            AllowChatClientEmployee = client.AllowChatClientEmployee,
            All = client.All,
            OnlyProjectMembercanwithclient = client.OnlyProjectMembercanwithclient,
            Allowchatclientadmin = client.Allowchatclientadmin,
            SoundNotifyAlert = client.SoundNotifyAlert
        };
    }
}
