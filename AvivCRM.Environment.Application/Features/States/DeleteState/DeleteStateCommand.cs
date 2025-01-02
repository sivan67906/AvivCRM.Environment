using MediatR;

namespace AvivCRM.Environment.Application.Features.States.DeleteState
{
    public class DeleteStateCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}













