namespace DigitalPaymentsApi.Domain;

public class Payment
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = default!;
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "EUR";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}