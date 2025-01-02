using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.CustomQuestionTypes.GetAllCustomQuestionTypes;

internal class GetAllCustomQuestionTypesQueryHandler : IRequestHandler<GetAllCustomQuestionTypesQuery, IEnumerable<CustomQuestionTypeDTO>>
{
    private readonly IGenericRepository<CustomQuestionType> _customQuestionTypeRepository;
    private readonly IGenericRepository<ProjectReminderPerson> _projectReminderPersonRepository;

    public GetAllCustomQuestionTypesQueryHandler(
        IGenericRepository<CustomQuestionType> customQuestionTypeRepository,
        IGenericRepository<ProjectReminderPerson> projectReminderPersonRepository)
    {
        _customQuestionTypeRepository = customQuestionTypeRepository;
        _projectReminderPersonRepository = projectReminderPersonRepository;
    }

    public async Task<IEnumerable<CustomQuestionTypeDTO>> Handle(GetAllCustomQuestionTypesQuery request, CancellationToken cancellationToken)
    {
        var customQuestionTypes = await _customQuestionTypeRepository.GetAllAsync();
        var customQuestionTypeList = customQuestionTypes.Select(x => new CustomQuestionTypeDTO
        {
            Id = x.Id,
            CQTypeCode = x.CQTypeCode,
            CQTypeName = x.CQTypeName
        }).ToList();

        return customQuestionTypeList;
    }
}
























