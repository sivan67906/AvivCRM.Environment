using AvivCRM.Environment.Application.DTOs.LeadCategories;
using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadCategories.GetAllLeadCategories
{
    public class GetAllLeadCategoryQueryHandler : IRequestHandler<GetAllLeadCategoryQuery, ServerResponse>
    {
        private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
        public GetAllLeadCategoryQueryHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

        public async Task<ServerResponse> Handle(GetAllLeadCategoryQuery request, CancellationToken cancellationToken)
        {
            var categories = await _repository.GetAllAsync();
            if (!categories.Any()) return new ServerResponse(IsSuccess: false, Message: "No Lead Categories there");

            var categorylist = categories.Select(x => new GetLeadCategory
            {
                Id = x.Id,
                CategoryName = x.CategoryName!
            }).ToList();

            return new ServerResponse(IsSuccess: true, Message: "GetAll Lead Categories Executed", Data: categorylist);
        }
    }
}


