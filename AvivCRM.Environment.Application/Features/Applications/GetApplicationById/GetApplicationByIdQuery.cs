using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Applications.GetApplicationById;
public class GetApplicationByIdQuery : IRequest<ApplicationDTO>
{
    public Guid Id { get; set; }
}
