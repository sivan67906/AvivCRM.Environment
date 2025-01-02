//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruitGeneralSettings.GetRecruitGeneralSettingById
{
    public class GetRecruitGeneralSettingByIdQuery : IRequest<RecruitGeneralSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























