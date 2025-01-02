//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruitJobApplicationStatusSettings.GetRecruitJobApplicationStatusSettingById
{
    public class GetRecruitJobApplicationStatusSettingByIdQuery : IRequest<RecruitJobApplicationStatusSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























