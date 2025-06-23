using ECommerce.Ordering.Domain.Entities;
using ECommerce.Ordering.Domain.Respositories;

namespace ECommerce.Ordering.Infrastructure.Data;

public class InMemoryOrderRepository : IOrderRepository
{
    private static readonly List<Order> _orders = new();

    public Task AddAsync(Order order)
    {
        _orders.Add(order);
        return Task.CompletedTask;
    }

    public static Order? GetById(Guid id) => _orders.FirstOrDefault(o => o.Id == id);
}
