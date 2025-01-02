using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.UpdateCustomQuestionType;

internal class UpdateCustomQuestionTypeCommandHandler : IRequestHandler<UpdateCustomQuestionTypeCommand>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;

    public UpdateCustomQuestionTypeCommandHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository) =>
        _customQuestionTypeRepository = customQuestionTypeRepository;

    public async System.Threading.Tasks.Task Handle(UpdateCustomQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        var customQuestionType = new CustomQuestionType
        {
            Id = request.Id,
            CQTypeCode = request.CQTypeCode,
            CQTypeName = request.CQTypeName,
            UpdatedDate = DateTime.Now
        };

        await _customQuestionTypeRepository.UpdateAsync(customQuestionType);
    }
}
























