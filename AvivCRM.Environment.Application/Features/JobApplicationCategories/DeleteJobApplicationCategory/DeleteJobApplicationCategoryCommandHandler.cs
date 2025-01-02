using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.DeleteJobApplicationCategory;

internal class DeleteJobApplicationCategoryCommandHandler : IRequestHandler<DeleteJobApplicationCategoryCommand>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public DeleteJobApplicationCategoryCommandHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;
    public async System.Threading.Tasks.Task Handle(DeleteJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        await _jobApplicationCategoryRepository.DeleteAsync(request.Id);
    }
}
























