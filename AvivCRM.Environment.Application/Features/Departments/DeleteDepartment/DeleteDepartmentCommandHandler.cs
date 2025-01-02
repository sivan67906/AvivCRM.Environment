using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Departments.DeleteDepartment;

internal class DeleteDepartmentCommandHandler : IRequestHandler<DeleteDepartmentCommand>
{
    private readonly IGenericRepository<Department> _departmentRepository;

    public DeleteDepartmentCommandHandler(
        IGenericRepository<Department> departmentRepository) =>
        _departmentRepository = departmentRepository;
    public async System.Threading.Tasks.Task Handle(DeleteDepartmentCommand request, CancellationToken cancellationToken)
    {
        await _departmentRepository.DeleteAsync(request.Id);
    }
}


