using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.UpdateCustomQuestionType;

public class UpdateCustomQuestionTypeCommand : IRequest
{
    public Guid Id { get; set; }
    public string? CQTypeCode { get; set; }
    public string? CQTypeName { get; set; }
}
























