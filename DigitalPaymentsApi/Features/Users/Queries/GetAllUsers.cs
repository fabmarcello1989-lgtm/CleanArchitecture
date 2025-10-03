using DigitalPaymentsApi.Domain;
using DigitalPaymentsApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace DigitalPaymentsApi.Features.Users.Queries;


public record GetAllUsers : IRequest<List<User>>;

public class GetAllUsersHandler : IRequestHandler<GetAllUsers, List<User>>
{
    private readonly AppDbContext _context;

    public GetAllUsersHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<User>> Handle(GetAllUsers request, CancellationToken cancellationToken)
    {
        return await _context.Users
            .Include(u => u.Payments)
            .ToListAsync(cancellationToken);
    }
}