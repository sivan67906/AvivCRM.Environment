using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.Cities.GetCityById
{
    public class GetCityByIdQuery : IRequest<CityDTO>
    {
        public Guid Id { get; set; }
    }
}

















