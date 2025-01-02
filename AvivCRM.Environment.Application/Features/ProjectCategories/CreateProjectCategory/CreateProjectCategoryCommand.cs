using MediatR;

namespace AvivCRM.Environment.Application.Features.ProjectCategories.CreateProjectCategory;

public class CreateProjectCategoryCommand : IRequest
{
    public string? Name { get; set; }
}












