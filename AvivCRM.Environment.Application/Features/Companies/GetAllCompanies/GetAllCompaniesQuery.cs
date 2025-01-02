using AvivCRM.Environment.Application.DTOs;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Companies.GetAllCompanies;

public class GetAllCompaniesQuery : IRequest<IEnumerable<CompanyDTO>>
{
}


