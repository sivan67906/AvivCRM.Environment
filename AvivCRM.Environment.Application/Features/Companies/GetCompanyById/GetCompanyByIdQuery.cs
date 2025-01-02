using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Companies.GetCompanyById
{
    public class GetCompanyByIdQuery : IRequest<CompanyDTO>
    {
        public Guid Id { get; set; }
    }
}


