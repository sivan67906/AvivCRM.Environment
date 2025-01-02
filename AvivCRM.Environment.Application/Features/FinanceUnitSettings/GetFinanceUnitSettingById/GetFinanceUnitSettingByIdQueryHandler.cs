using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.GetFinanceUnitSettingById;

internal class GetFinanceUnitSettingByIdQueryHandler : IRequestHandler<GetFinanceUnitSettingByIdQuery, FinanceUnitSettingDTO>
{
    private readonly IGenericRepository<FinanceUnitSetting> _financeUnitSettingRepository;

    public GetFinanceUnitSettingByIdQueryHandler(
        IGenericRepository<FinanceUnitSetting> financeUnitSettingRepository) =>
        _financeUnitSettingRepository = financeUnitSettingRepository;

    public async Task<FinanceUnitSettingDTO> Handle(GetFinanceUnitSettingByIdQuery request, CancellationToken cancellationToken)
    {
        var financeUnitSetting = await _financeUnitSettingRepository.GetByIdAsync(request.Id);
        if (financeUnitSetting == null) return null;
        return new FinanceUnitSettingDTO
        {
            Id = financeUnitSetting.Id,
            FUnitCode = financeUnitSetting.FUnitCode,
            FUnitName = financeUnitSetting.FUnitName,
            FIsDefault = financeUnitSetting.FIsDefault
        };
    }
}
































