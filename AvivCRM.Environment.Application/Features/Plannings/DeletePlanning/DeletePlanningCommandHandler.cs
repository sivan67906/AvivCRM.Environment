using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Plannings.DeletePlanning;
public class DeletePlanningCommandHandler : IRequestHandler<DeletePlanningCommand>
{
    private readonly IGenericRepository<Planning> _planrepo;
    public DeletePlanningCommandHandler(IGenericRepository<Planning> planrepo) => _planrepo = planrepo;

    public async System.Threading.Tasks.Task Handle(DeletePlanningCommand request, CancellationToken cancellationToken)
    {
        if (request == null || request.Id == null)
        {
            throw new ArgumentNullException(nameof(request), "Request or Request.Id cannot be null.");
        }

        await _planrepo.DeleteAsync(request.Id);
    }
}
