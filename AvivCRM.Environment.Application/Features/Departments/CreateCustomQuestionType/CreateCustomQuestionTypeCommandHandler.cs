using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Departments.CreateCustomQuestionType;

internal class CreateCustomQuestionTypeCommandHandler(
    IGenericRepository<CustomQuestionType> customQuestionTypeRepository) : IRequestHandler<CreateCustomQuestionTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateCustomQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        var customQuestionType = new CustomQuestionType
        {
            CQTypeCode = request.CQTypeCode,
            CQTypeName = request.CQTypeName,
            CreatedDate = DateTime.Now,
            IsActive = true
        };

        await customQuestionTypeRepository.CreateAsync(customQuestionType);
    }
}
























