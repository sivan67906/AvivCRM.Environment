using MediatR;

namespace AvivCRM.Environment.Application.Features.JobApplicationCategories.UpdateJobApplicationCategory;

public class UpdateJobApplicationCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? JACategoryCode { get; set; }
    public string? JACategoryName { get; set; }
}
























