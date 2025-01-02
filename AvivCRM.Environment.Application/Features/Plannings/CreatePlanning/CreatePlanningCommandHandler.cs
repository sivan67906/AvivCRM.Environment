using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Plannings.CreatePlanning;
public class CreatePlanningCommandHandler : IRequestHandler<CreatePlanningCommand, Guid>
{
    private readonly IGenericRepository<Planning> _planningrepo;
    public CreatePlanningCommandHandler(IGenericRepository<Planning> planningrepo) => _planningrepo = planningrepo;

    public async Task<Guid> Handle(CreatePlanningCommand request, CancellationToken cancellationToken)
    {
        var plan = new Planning
        {
            Name = request.Name,
            PlanPrice = request.PlanPrice,
            Description = request.Description,
            Validity = request.Validity,
            Employee = request.Employee,
            Designation = request.Designation,
            Department = request.Department,
            Company = request.Company,
            Roles = request.Roles,
            Permission = request.Permission,
        };

        await _planningrepo.CreateAsync(plan);
        return plan.Id;
    }
}
