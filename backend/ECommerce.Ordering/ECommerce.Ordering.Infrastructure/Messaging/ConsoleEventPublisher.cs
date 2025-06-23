using ECommerce.Ordering.Application.Interfaces;
using ECommerce.Ordering.Domain.Events;

namespace ECommerce.Ordering.Infrastructure.Messaging;

public class ConsoleEventPublisher : IEventPublisher
{
    public Task PublishAsync(OrderCreatedEvent @event)
    {
        Console.WriteLine($">>> Event published: OrderCreated - Id={@event.OrderId}, Total={@event.Total}");
        return Task.CompletedTask;
    }
}
