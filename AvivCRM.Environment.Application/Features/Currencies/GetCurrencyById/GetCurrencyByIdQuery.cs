using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Currencies.GetCurrencyById;
public class GetCurrencyByIdQuery : IRequest<CurrencyDTO>
{
    public Guid Id { get; set; }
}
