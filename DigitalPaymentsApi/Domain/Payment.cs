namespace DigitalPaymentsApi.Domain;

public class Payment
{
    public Guid Id { get; set; }
    public decimal Amount { get; set; }
    public string Currency { get; set; } = "EUR";
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;


    // Relazione con User
    public Guid UserId { get; set; }
    public User? User { get; set; }

}