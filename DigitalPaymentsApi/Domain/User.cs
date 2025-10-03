using DigitalPaymentsApi.Domain;

public class User
{
    public Guid Id { get; set; }
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; }

    // Relazione: un utente ha molti pagamenti
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}