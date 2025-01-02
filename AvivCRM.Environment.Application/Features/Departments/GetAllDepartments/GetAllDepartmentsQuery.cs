using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Departments.GetAllDepartments;

public class GetAllDepartmentsQuery : IRequest<IEnumerable<DepartmentDTO>>
{

}


