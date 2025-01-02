using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.CreateJobApplicationCategory;

internal class CreateJobApplicationCategoryCommandHandler(
    IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) : IRequestHandler<CreateJobApplicationCategoryCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateJobApplicationCategoryCommand request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = new JobApplicationCategory
        {
            JACategoryCode = request.JACategoryCode,
            JACategoryName = request.JACategoryName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await jobApplicationCategoryRepository.CreateAsync(jobApplicationCategory);
    }
}
























