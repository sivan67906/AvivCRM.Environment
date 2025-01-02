using MediatR;

namespace AvivCRM.Environment.Application.Features.Companies.DeleteCompany
{
    public class DeleteCompanyCommand : IRequest
    {
        public Guid Id { get; set; }
    }
}


