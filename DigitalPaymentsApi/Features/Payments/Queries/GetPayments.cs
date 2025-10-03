using DigitalPaymentsApi.Features.Payments.Dtos;
using DigitalPaymentsApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace DigitalPaymentsApi.Features.Payments.Queries;

public record GetPayments : IRequest<List<PaymentDto>>;

public class GetPaymentsHandler : IRequestHandler<GetPayments, List<PaymentDto>>
{
    private readonly AppDbContext _context;

    public GetPaymentsHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<PaymentDto>> Handle(GetPayments request, CancellationToken cancellationToken)
    {
        return await _context.Payments
            .Select(p => new PaymentDto(p.Id, p.UserId, p.Amount, p.Currency, p.CreatedAt))
            .ToListAsync(cancellationToken);
    }
}
