using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.UpdateJobApplicationCategory;

internal class UpdateJobApplicationCategoryCommandHandler : IRequestHandler<UpdateJobApplicationCategoryCommand>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public UpdateJobApplicationCategoryCommandHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;

    public async System.Threading.Tasks.Task Handle(UpdateJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = new JobApplicationCategory
        {
            Id = request.Id,
            JACategoryCode = request.JACategoryCode,
            JACategoryName = request.JACategoryName,
            UpdatedDate = DateTime.Now
        };

        await _jobApplicationCategoryRepository.UpdateAsync(jobApplicationCategory);
    }
}
























