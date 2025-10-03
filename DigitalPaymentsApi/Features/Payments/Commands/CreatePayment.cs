using DigitalPaymentsApi.Domain;
using DigitalPaymentsApi.Infrastructure;
using MediatR;

namespace DigitalPaymentsApi.Features.Payments.Commands;

public record CreatePayment(string UserId, decimal Amount, string Currency) : IRequest<Guid>;

public class CreatePaymentHandler : IRequestHandler<CreatePayment, Guid>
{
    private readonly AppDbContext _context;

    public CreatePaymentHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreatePayment request, CancellationToken cancellationToken)
    {
        var payment = new Payment
        {
            Id = Guid.NewGuid(),
            UserId = request.UserId,
            Amount = request.Amount,
            Currency = request.Currency
        };

        _context.Payments.Add(payment);
        await _context.SaveChangesAsync(cancellationToken);

        return payment.Id;
    }
}
