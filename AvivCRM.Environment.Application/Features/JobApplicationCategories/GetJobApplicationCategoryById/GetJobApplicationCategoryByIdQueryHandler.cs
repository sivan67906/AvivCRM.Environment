using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.GetJobApplicationCategoryById;

internal class GetJobApplicationCategoryByIdQueryHandler : IRequestHandler<GetJobApplicationCategoryByIdQuery, JobApplicationCategoryDTO>
{
    private readonly IGenericRepository<JobApplicationCategory> _jobApplicationCategoryRepository;

    public GetJobApplicationCategoryByIdQueryHandler(
        IGenericRepository<JobApplicationCategory> jobApplicationCategoryRepository) =>
        _jobApplicationCategoryRepository = jobApplicationCategoryRepository;

    public async Task<JobApplicationCategoryDTO> Handle(GetJobApplicationCategoryByIdQuery request, CancellationToken cancellationToken)
    {
        var jobApplicationCategory = await _jobApplicationCategoryRepository.GetByIdAsync(request.Id);
        if (jobApplicationCategory == null) return null;
        return new JobApplicationCategoryDTO
        {
            Id = jobApplicationCategory.Id,
            JACategoryCode = jobApplicationCategory.JACategoryCode,
            JACategoryName = jobApplicationCategory.JACategoryName
        };
    }
}
























