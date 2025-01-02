using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessLocations.GetBusinessLocationById
{
    public class GetBusinessLocationByIdQuery : IRequest<BusinessLocationDTO>
    {
        public Guid Id { get; set; }
    }
}

