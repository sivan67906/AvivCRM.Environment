using AvivCRM.Environment.Domain.Interfaces;
using AvivCRM.Environment.Domain.Responses;
using MediatR;

namespace AvivCRM.Environment.Application.Features.LeadCategories.DeleteLeadCategory;

public class DeleteLeadCategoryCommandHandler : IRequestHandler<DeleteLeadCategoryCommand, ServerResponse>
{
    private readonly IGenericRepository<Domain.Entities.LeadCategory> _repository;
    public DeleteLeadCategoryCommandHandler(IGenericRepository<Domain.Entities.LeadCategory> repository) => _repository = repository;

    public async Task<ServerResponse> Handle(DeleteLeadCategoryCommand request, CancellationToken cancellationToken)
    {
        var category = await _repository.GetByIdAsync(request.Id);
        if (category == null) return new ServerResponse(Message: "No Lead Categories mapped with this Id");
        await _repository.DeleteAsync(request.Id);
        return new ServerResponse(IsSuccess: true, Message: "Deleted Successfully");
    }
}


