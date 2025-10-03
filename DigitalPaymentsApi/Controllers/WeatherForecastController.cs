using DigitalPaymentsApi.Features.Payments;
using DigitalPaymentsApi.Features.Payments.Commands;
using DigitalPaymentsApi.Features.Payments.Dtos;
using DigitalPaymentsApi.Features.Payments.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace DigitalPaymentsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PaymentsController : ControllerBase
{
    private readonly IMediator _mediator;

    public PaymentsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePayment command)
    {
        var id = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetAll), new { id }, id);
    }

    [HttpGet]
    public async Task<ActionResult<List<PaymentDto>>> GetAll()
    {
        var payments = await _mediator.Send(new GetPayments());
        return Ok(payments);
    }
}