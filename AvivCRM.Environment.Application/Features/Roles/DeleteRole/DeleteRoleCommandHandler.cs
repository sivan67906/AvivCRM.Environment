using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Roles.DeleteRole;

internal class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand>
{
    private readonly IGenericRepository<Role> _roleRepository;

    public DeleteRoleCommandHandler(
        IGenericRepository<Role> roleRepository) =>
        _roleRepository = roleRepository;
    public async System.Threading.Tasks.Task Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
    {
        await _roleRepository.DeleteAsync(request.Id);
    }
}





