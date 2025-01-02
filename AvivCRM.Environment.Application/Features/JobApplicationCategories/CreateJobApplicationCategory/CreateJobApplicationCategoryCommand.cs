using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.CreateJobApplicationCategory;

public class CreateJobApplicationCategoryCommand : IRequest
{
    public string? JACategoryCode { get; set; }
    public string? JACategoryName { get; set; }
}
























