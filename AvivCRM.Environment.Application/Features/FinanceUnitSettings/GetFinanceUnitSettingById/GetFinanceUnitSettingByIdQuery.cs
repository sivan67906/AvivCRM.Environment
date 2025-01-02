//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.FinanceUnitSettings.GetFinanceUnitSettingById
{
    public class GetFinanceUnitSettingByIdQuery : IRequest<FinanceUnitSettingDTO>
    {
        public Guid Id { get; set; }
    }
}
































