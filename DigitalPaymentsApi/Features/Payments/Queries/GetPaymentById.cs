using DigitalPaymentsApi.Domain;
using DigitalPaymentsApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

public record GetPaymentById(Guid Id) : IRequest<Payment?>;

public class GetPaymentByIdHandler : IRequestHandler<GetPaymentById, Payment?>
{
    private readonly AppDbContext _context;

    public GetPaymentByIdHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Payment?> Handle(GetPaymentById request, CancellationToken cancellationToken)
    {
        return await _context.Payments
            .FirstOrDefaultAsync(p => p.Id == request.Id, cancellationToken);
    }
}