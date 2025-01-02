using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Plannings.GetAllPlannings;
public class GetAllPlanningsQueryHandler : IRequestHandler<GetAllPlanningsQuery, IEnumerable<PlanningDTO>>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public GetAllPlanningsQueryHandler(IGenericRepository<Planning> planrepo) => _planrepo = planrepo;


    public async Task<IEnumerable<PlanningDTO>> Handle(GetAllPlanningsQuery request, CancellationToken cancellationToken)
    {
        var clients = await _planrepo.GetAllAsync();

        var clientlist = clients.Select(x => new PlanningDTO
        {
            Id = x.Id,
            Name = x.Name,
            PlanPrice = x.PlanPrice,
            Description = x.Description,
            Validity = x.Validity,
            Employee = x.Employee,
            Designation = x.Designation,
            Department = x.Department,
            Company = x.Company,
            Roles = x.Roles,
            Permission = x.Permission,
        }).ToList();

        return clientlist;
    }
}
