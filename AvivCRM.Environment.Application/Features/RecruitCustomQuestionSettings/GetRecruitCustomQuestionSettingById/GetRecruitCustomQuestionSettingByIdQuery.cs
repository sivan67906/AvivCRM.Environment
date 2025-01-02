//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruitCustomQuestionSettings.GetRecruitCustomQuestionSettingById
{
    public class GetRecruitCustomQuestionSettingByIdQuery : IRequest<RecruitCustomQuestionSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























