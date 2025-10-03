using DigitalPaymentsApi.Domain;
using DigitalPaymentsApi.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;
namespace DigitalPaymentsApi.Features.Users.Commands;

public record CreateUser(string Username, string Email, string password) : IRequest<User>;

public class CreateUserHandler : IRequestHandler<CreateUser, User>
{
    private readonly AppDbContext _context;

    public CreateUserHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<User> Handle(CreateUser request, CancellationToken cancellationToken)
    {
        var user = new User
        {
            Id = Guid.NewGuid(),
            Username = request.Username,
            Email = request.Email,
            Password = request.password
        };

        _context.Users.Add(user);
        await _context.SaveChangesAsync(cancellationToken);

        return user;
    }
}