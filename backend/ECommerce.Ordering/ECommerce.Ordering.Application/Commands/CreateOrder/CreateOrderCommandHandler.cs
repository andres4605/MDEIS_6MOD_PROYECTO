using ECommerce.Ordering.Application.Interfaces;
using ECommerce.Ordering.Domain.Entities;
using ECommerce.Ordering.Domain.Events;
using ECommerce.Ordering.Domain.Respositories;
using MediatR;

namespace ECommerce.Ordering.Application.Commands.CreateOrder;

public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, bool>
{
    private readonly IOrderRepository _repository;
    private readonly IEventPublisher _eventPublisher;

    public CreateOrderCommandHandler(IOrderRepository repository, IEventPublisher eventPublisher)
    {
        _repository = repository;
        _eventPublisher = eventPublisher;
    }

    public async Task<bool> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
    {
        var order = new Order(request.OrderId, request.ProductIds);
        await _repository.AddAsync(order);
        await _eventPublisher.PublishAsync(new OrderCreatedEvent(order.Id, order.Total));
        return true;
    }
}
