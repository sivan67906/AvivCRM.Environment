using MediatR;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.DeleteBusinessType
{
    public class DeleteBusinessTypeCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}






