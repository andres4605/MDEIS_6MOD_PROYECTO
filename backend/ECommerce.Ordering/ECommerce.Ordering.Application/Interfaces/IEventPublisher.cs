using ECommerce.Ordering.Domain.Events;

namespace ECommerce.Ordering.Application.Interfaces;

public interface IEventPublisher
{
    Task PublishAsync(OrderCreatedEvent @event);
}
