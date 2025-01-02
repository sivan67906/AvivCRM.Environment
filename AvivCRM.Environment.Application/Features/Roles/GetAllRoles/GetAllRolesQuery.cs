using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Roles.GetAllRoles;

public class GetAllRolesQuery : IRequest<IEnumerable<RoleDTO>>
{
}





