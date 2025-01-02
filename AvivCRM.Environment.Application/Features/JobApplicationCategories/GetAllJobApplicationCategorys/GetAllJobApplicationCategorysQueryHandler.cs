using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.GetAllJobApplicationCategorys;

internal class GetAllJobApplicationCategoriesQueryHandler : IRequestHandler<GetAllJobApplicationCategoriesQuery, IEnumerable<JobApplicationCategoryDTO>>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllJobApplicationCategoriesQueryHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<JobApplicationCategoryDTO>> Handle(GetAllJobApplicationCategoriesQuery request, CancellationToken cancellationToken)
    {
        var jobApplicationCategories = await _jobApplicationCategoryRepository.GetAllAsync();
        var jobApplicationCategoryList = jobApplicationCategories.Select(x => new JobApplicationCategoryDTO
        {
            Id = x.Id,
            JACategoryCode = x.JACategoryCode,
            JACategoryName = x.JACategoryName
        }).ToList();

        return jobApplicationCategoryList;
    }
}
























