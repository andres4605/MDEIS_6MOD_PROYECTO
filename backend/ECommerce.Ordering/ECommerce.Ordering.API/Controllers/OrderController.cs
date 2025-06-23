using ECommerce.Ordering.Application.Commands.CreateOrder;
using ECommerce.Ordering.Application.Queries.GetOrderById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Ordering.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMediator _mediator;

    public OrderController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreateOrderCommand command)
    {
        var result = await _mediator.Send(command);
        return result ? Ok() : BadRequest();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _mediator.Send(new GetOrderByIdQuery(id));
        return result is not null ? Ok(result) : NotFound();
    }
}
