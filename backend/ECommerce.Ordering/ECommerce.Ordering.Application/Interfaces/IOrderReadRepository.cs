using ECommerce.Ordering.Application.Queries.GetOrderById;

namespace ECommerce.Ordering.Application.Interfaces;

public interface IOrderReadRepository
{
    Task<OrderDto?> GetByIdAsync(Guid id);
}
