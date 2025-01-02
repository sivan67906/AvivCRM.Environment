using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Plannings.UpdatePlanning;
public class UpdatePlanningCommandHandler : IRequestHandler<UpdatePlanningCommand, Guid>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public UpdatePlanningCommandHandler(IGenericRepository<Planning> planrepo) => _planrepo = planrepo;

    public async Task<Guid> Handle(UpdatePlanningCommand request, CancellationToken cancellationToken)
    {
        var product = new Planning
        {
            Id = request.Id,
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
        await _planrepo.UpdateAsync(product);
        return request.Id;
    }
}
