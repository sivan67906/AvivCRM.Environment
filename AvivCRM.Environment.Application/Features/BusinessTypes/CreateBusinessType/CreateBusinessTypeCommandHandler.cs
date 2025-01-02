using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.BusinessTypes.CreateBusinessType;

internal class CreateBusinessTypeCommandHandler(
    IGenericRepository<BusinessType> businessTypeRepository) : IRequestHandler<CreateBusinessTypeCommand>
{
    public async System.Threading.Tasks.Task Handle(CreateBusinessTypeCommand request, CancellationToken cancellationToken)
    {
        var businessType = new BusinessType
        {

        };

        await businessTypeRepository.CreateAsync(businessType);
    }
}






