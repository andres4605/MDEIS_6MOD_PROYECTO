using ECommerce.Ordering.Application.Interfaces;
using ECommerce.Ordering.Application.Queries.GetOrderById;

namespace ECommerce.Ordering.Infrastructure.Data;

public class InMemoryOrderReadRepository : IOrderReadRepository
{
    public Task<OrderDto?> GetByIdAsync(Guid id)
    {
        var order = InMemoryOrderRepository.GetById(id);
        if (order == null) return Task.FromResult<OrderDto?>(null);

        return Task.FromResult<OrderDto?>(new OrderDto
        {
            Id = order.Id,
            Total = order.Total,
            ProductIds = order.ProductIds
        });
    }
}
