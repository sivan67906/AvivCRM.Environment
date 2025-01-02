using MediatR;

namespace AvivCRM.Environment.Application.Features.Departments.CreateCustomQuestionType;

public class CreateCustomQuestionTypeCommand : IRequest
{
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}
























