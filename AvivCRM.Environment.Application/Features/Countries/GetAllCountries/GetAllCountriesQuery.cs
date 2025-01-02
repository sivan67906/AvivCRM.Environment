using MediatR;
using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Features.Countries.GetAllCountries;

public class GetAllCountriesQuery : IRequest<IEnumerable<CountryDTO>>
{
}













