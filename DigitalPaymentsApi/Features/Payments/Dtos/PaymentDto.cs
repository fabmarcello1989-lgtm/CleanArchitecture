namespace DigitalPaymentsApi.Features.Payments.Dtos;

public record PaymentDto(Guid Id, Guid UserId, decimal Amount, string Currency, DateTime CreatedAt);
