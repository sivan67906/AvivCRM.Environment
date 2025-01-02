//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.RecruiterSettings.GetRecruiterSettingById
{
    public class GetRecruiterSettingByIdQuery : IRequest<RecruiterSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
























