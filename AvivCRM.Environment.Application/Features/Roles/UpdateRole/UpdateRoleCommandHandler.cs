using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Roles.UpdateRole;

internal class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand>
{
    private readonly IGenericRepository<Role> _roleRepository;

    public UpdateRoleCommandHandler(
        IGenericRepository<Role> roleRepository) =>
        _roleRepository = roleRepository;

    public async System.Threading.Tasks.Task Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
    {
        var role = new Role
        {
            Id = request.Id,
            Code = request.Code,
            Name = request.Name,
            Description = request.Description,
            CompanyId = request.CompanyId,
            DepartmentId = request.DepartmentId,
            DesignationId = request.DesignationId,
            UpdatedDate = DateTime.Now,
            IsActive = request.IsActive,
        };

        await _roleRepository.UpdateAsync(role);
    }
}





