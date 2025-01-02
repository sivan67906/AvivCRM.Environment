using MediatR;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.DeleteCustomQuestionType
{
    public class DeleteCustomQuestionTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}
























