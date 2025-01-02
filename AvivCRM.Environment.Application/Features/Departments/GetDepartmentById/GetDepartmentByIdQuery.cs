using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Departments.GetDepartmentById
{
    public class GetDepartmentByIdQuery : IRequest<DepartmentDTO>
    {
        public Guid Id { get; set; }
    }
}


