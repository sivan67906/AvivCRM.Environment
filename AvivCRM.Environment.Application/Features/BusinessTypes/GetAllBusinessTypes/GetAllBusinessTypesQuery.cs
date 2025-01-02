using AvivCRM.Environment.Domain.Entities;
using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.GetAllBusinessTypes;

public class GetAllBusinessTypesQuery : IRequest<IEnumerable<BusinessTypeDTO>>
{
}






