namespace DigitalPaymentsApi.Features.Payments.Dtos;

public record PaymentDto(Guid Id, string UserId, decimal Amount, string Currency, DateTime CreatedAt);
