using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;
using MediatR;

namespace AvivCRM.Environment.Application.Features.Designations.GetAllDesignations;

internal class GetAllDesignationsQueryHandler : IRequestHandler<GetAllDesignationsQuery, IEnumerable<DesignationDTO>>
{
    private readonly IGenericRepository<Designation> _designationRepository;

    public GetAllDesignationsQueryHandler(
        IGenericRepository<Designation> designationRepository) =>
        _designationRepository = designationRepository;

    public async Task<IEnumerable<DesignationDTO>> Handle(GetAllDesignationsQuery request, CancellationToken cancellationToken)
    {
        var designations = await _designationRepository.GetAllAsync();

        var designationList = designations.Select(x => new DesignationDTO
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            CompanyId = x.CompanyId,
            DepartmentId = x.DepartmentId,
            CompanyName = x.Company.Name,
            DepartmentName = x.Department.Name,
            Description = x.Description,
            CreatedDate = x.CreatedDate,
            UpdatedDate = x.UpdatedDate,
            IsActive = x.IsActive
        }).ToList();

        return designationList;
    }
}






