using MediatR;

namespace ECommerce.Ordering.Application.Queries.GetOrderById;

public record GetOrderByIdQuery(Guid OrderId) : IRequest<OrderDto>;
