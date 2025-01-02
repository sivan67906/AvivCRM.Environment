//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruitNotificationSettings.GetRecruitNotificationSettingById
{
    public class GetRecruitNotificationSettingByIdQuery : IRequest<RecruitNotificationSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























