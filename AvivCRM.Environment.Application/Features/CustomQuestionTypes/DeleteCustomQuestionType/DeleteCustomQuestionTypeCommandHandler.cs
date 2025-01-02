using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.DeleteCustomQuestionType;

internal class DeleteCustomQuestionTypeCommandHandler : IRequestHandler<DeleteCustomQuestionTypeCommand>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;

    public DeleteCustomQuestionTypeCommandHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository) =>
        _customQuestionTypeRepository = customQuestionTypeRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCustomQuestionTypeCommand request, CancellationToken cancellationToken)
    {
        await _customQuestionTypeRepository.DeleteAsync(request.Id);
    }
}
























