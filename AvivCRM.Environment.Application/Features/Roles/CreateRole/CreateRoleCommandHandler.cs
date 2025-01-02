using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Roles.CreateRole;

internal class CreateRoleCommandHandler(
    IGenericRepository<Role> roleRepository) : IRequestHandler<CreateRoleCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = new Role
        {
            Code = request.Code,
            Name = request.Name,
            Description = request.Description,
            CompanyId = request.CompanyId,
            DepartmentId = request.DepartmentId,
            DesignationId = request.DesignationId,
            CreatedDate = DateTime.Now,
            IsActive = request.IsActive,
        };

        await roleRepository.CreateAsync(role);
    }
}





