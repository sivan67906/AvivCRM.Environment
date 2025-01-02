using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Designations.GetDesignationById
{
    public class GetDesignationByIdQuery : IRequest<DesignationDTO>
    {
        public Guid Id { get; set; }
    }
}






