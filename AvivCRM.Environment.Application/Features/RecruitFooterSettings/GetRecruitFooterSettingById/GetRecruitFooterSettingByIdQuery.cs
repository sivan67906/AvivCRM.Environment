//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruitFooterSettings.GetRecruitFooterSettingById
{
    public class GetRecruitFooterSettingByIdQuery : IRequest<RecruitFooterSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























