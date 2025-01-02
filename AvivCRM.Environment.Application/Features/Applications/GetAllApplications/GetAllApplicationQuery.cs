using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Applications.GetAllApplications;
public class GetAllApplicationQuery : IRequest<IEnumerable<ApplicationDTO>>
{

}
