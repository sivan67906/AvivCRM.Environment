using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.UpdateProjectCategory;

public class UpdateProjectCategoryCommand : IRequest
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
}












