using AvivCRM.Environment.Domain.Entities;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.GetBusinessTypeById
{
    public class GetBusinessTypeByIdQuery : IRequest<BusinessTypeDTO>
    {
        public Guid Id { get; set; }
    }
}






