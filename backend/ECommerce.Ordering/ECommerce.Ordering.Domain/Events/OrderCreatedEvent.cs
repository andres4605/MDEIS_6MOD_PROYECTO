namespace ECommerce.Ordering.Domain.Events;

public record OrderCreatedEvent(Guid OrderId, decimal Total);
