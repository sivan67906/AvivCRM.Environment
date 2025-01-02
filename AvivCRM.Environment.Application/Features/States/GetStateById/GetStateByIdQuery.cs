using MediatR;
using AvivCRM.Environment.Application.DTOs;

namespace AvivCRM.Environment.Application.Features.States.GetStateById
{
    public class GetStateByIdQuery : IRequest<StateDTO>
    {
        public Guid Id { get; set; }
    }
}













