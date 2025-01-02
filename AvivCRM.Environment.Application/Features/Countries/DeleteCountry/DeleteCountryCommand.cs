using MediatR;

namespace AvivCRM.Environment.Application.Features.Countries.DeleteCountry
{
    public class DeleteCountryCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}













