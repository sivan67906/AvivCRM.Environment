using MediatR;
using AvivCRM.Environment.Domain.Entities;

namespace AvivCRM.Environment.Application.Features.Countries.GetCountryById
{
    public class GetCountryByIdQuery : IRequest<CountryDTO>
    {
        public Guid Id { get; set; }
    }
}













