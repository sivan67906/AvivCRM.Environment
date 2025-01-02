using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Designations.GetDesignationById;

internal class GetDesignationByIdQueryHandler : IRequestHandler<GetDesignationByIdQuery, DesignationDTO>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public GetDesignationByIdQueryHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;

    public async Task<DesignationDTO> Handle(GetDesignationByIdQuery request, CancellationToken cancellationToken)
    {
        var designation = await _designationRepository.GetByIdAsync(request.Id);
        if (designation == null) return null;
        return new DesignationDTO
        {
            Id = designation.Id,
            Code = designation.Code,
            Name = designation.Name,
            CompanyId = designation.CompanyId,
            DepartmentId = designation.DepartmentId,
            Description = designation.Description,
            CreatedDate = designation.CreatedDate,
            UpdatedDate = designation.UpdatedDate,
            IsActive = designation.IsActive
        };
    }
}






