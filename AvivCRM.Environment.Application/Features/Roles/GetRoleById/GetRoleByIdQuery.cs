using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Roles.GetRoleById
{
    public class GetRoleByIdQuery : IRequest<RoleDTO>
    {
        public Guid Id { get; set; }
    }
}





