using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Payments.UpdatePayment;
public class UpdatePaymentCommandHandler : IRequestHandler<UpdatePaymentCommand, Guid>
{
    private readonly IGenericRepository<Payment> _repository;
    public UpdatePaymentCommandHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(UpdatePaymentCommand request, CancellationToken cancellationToken)
    {
        var product = new Payment
        {
            Id = request.Id,
            Method = request.Method,
            Description = request.Description,
            Status = request.Status
        };
        await _repository.UpdateAsync(product);
        return request.Id;
    }
}
