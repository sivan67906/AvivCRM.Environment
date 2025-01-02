using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Companies.DeleteCompany;

internal class DeleteCompanyCommandHandler : IRequestHandler<DeleteCompanyCommand>
{
    private readonly IGenericRepository<Company> _companyRepository;

    public DeleteCompanyCommandHandler(
        IGenericRepository<Company> companyRepository) =>
        _companyRepository = companyRepository;
    public async System.Threading.Tasks.Task Handle(DeleteCompanyCommand request, CancellationToken cancellationToken)
    {
        await _companyRepository.DeleteAsync(request.Id);
    }
}


