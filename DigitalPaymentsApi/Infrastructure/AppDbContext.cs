using DigitalPaymentsApi.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DigitalPaymentsApi.Infrastructure;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<Payment> Payments => Set<Payment>();
}