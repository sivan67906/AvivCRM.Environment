using MediatR;
using AvivCRM.Environment.Application.DTOs.LeadCategories;
using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Domain.Responses;

namespace AvivCRM.Environment.Application.Features.LeadCategories.GetLeadCategoryById
{
    public class GetLeadCategoryByIdQueryHandler : IRequestHandler<GetLeadCategoryByIdQuery, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _leadcategoryRepository;
        public GetLeadCategoryByIdQueryHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _leadcategoryRepository = repository;

        public async Task<ServerResponse> Handle(GetLeadCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _leadcategoryRepository.GetByIdAsync(request.Id);
            if (category == null) return new ServerResponse(IsSuccess: false, Message: "No Lead Categories mapped with this Id");
            GetLeadCategory leadCategory = new GetLeadCategory
            {
                Id = category.Id,
                CategoryName = category.CategoryName!
            };
            return new ServerResponse(IsSuccess: true, Message: "GetByLead CategoryId executed", Data: leadCategory);
        }
    }
}