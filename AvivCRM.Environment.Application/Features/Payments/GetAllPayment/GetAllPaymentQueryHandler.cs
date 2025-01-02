using MediatR;
using AvivCRM.Environment.Application.DTOs;
using AvivCRM.Environment.Domain.Entities;
using AvivCRM.Environment.Domain.Interfaces;

namespace AvivCRM.Environment.Application.Features.Payments.GetAllPayment;
public class GetAllPaymentQueryHandler : IRequestHandler<GetAllPaymentQuery, IEnumerable<PaymentDTO>>
{
    private readonly IGenericRepository<Payment> _repository;
    public GetAllPaymentQueryHandler(IGenericRepository<Payment> repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<PaymentDTO>> Handle(GetAllPaymentQuery request, CancellationToken cancellationToken)
    {
        var clients = await _repository.GetAllAsync();

        var clientlist = clients.Select(x => new PaymentDTO
        {
            Id = x.Id,
            Method = x.Method,
            Description = x.Description,
            Status = x.Status
        }).ToList();

        return clientlist;
    }
}
