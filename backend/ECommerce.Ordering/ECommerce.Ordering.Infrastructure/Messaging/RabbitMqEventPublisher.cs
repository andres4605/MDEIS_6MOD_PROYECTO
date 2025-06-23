using ECommerce.Ordering.Application.Interfaces;
using ECommerce.Ordering.Domain.Events;
using MassTransit;

namespace ECommerce.Ordering.Infrastructure.Messaging;

public class RabbitMqEventPublisher : IEventPublisher
{
    private readonly IPublishEndpoint _publishEndpoint;

    public RabbitMqEventPublisher(IPublishEndpoint publishEndpoint)
    {
        _publishEndpoint = publishEndpoint;
    }

    public async Task PublishAsync(OrderCreatedEvent @event)
    {
        await _publishEndpoint.Publish(@event);
    }
}
