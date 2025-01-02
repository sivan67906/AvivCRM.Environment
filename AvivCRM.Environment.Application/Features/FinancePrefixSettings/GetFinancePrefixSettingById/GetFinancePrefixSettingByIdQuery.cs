//using AvivCRM.Environment.Application.DTOs;
using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.FinancePrefixSettings.GetFinancePrefixSettingById
{
    public class GetFinancePrefixSettingByIdQuery : IRequest<FinancePrefixSettingDTO>
    {
        public Guid Id { get; set; }
    }
}




































