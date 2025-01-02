using MediatR;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Payments.CreatePayment;
public class CreatePaymentCommandHandler : IRequestHandler<CreatePaymentCommand, Guid>
{
    private readonly IGenericRepository<Payment> _repository;
    public CreatePaymentCommandHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<Guid> Handle(CreatePaymentCommand request, CancellationToken cancellationToken)
    {
        var client = new Payment
        {
            Method = request.Method,
            Description = request.Description,
            Status = request.Status
        };

        await _repository.CreateAsync(client);
        return client.Id;
    }
}
