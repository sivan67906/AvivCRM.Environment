using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.GetBusinessTypeById;

internal class GetBusinessTypeByIdQueryHandler : IRequestHandler<GetBusinessTypeByIdQuery, BusinessTypeDTO>
{
    private readonly IGenericRepository<BusinessType> _businessTypeRepository;

    public GetBusinessTypeByIdQueryHandler(
        IGenericRepository<BusinessType> businessTypeRepository) =>
        _businessTypeRepository = businessTypeRepository;

    public async Task<BusinessTypeDTO> Handle(GetBusinessTypeByIdQuery request, CancellationToken cancellationToken)
    {
        var businessType = await _businessTypeRepository.GetByIdAsync(request.Id);
        if (businessType == null) return null;
        return new BusinessTypeDTO
        {
        };
    }
}






