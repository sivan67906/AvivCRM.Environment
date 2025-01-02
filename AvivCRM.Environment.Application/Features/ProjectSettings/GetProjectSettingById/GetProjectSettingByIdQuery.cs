//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.ProjectSettings.GetProjectSettingById
{
    public class GetProjectSettingByIdQuery : IRequest<ProjectSettingDTO>
    {
        public Guid Id { get; set; }
    }
}




















