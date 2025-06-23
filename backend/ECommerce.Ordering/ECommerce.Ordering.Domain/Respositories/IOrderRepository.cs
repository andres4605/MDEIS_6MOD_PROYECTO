using ECommerce.Ordering.Domain.Entities;

namespace ECommerce.Ordering.Domain.Respositories;

public interface IOrderRepository
{
    Task AddAsync(Order order);
}
