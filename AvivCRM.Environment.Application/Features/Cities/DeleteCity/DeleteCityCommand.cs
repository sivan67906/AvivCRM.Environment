using MediatR;

namespace AvivCRM.Environment.Application.Features.Cities.DeleteCity
{
    public class DeleteCityCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}

















