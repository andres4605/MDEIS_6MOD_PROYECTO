using ECommerce.Ordering.Application.Interfaces;
using MediatR;

namespace ECommerce.Ordering.Application.Queries.GetOrderById;

public class GetOrderByIdHandler : IRequestHandler<GetOrderByIdQuery, OrderDto>
{
    private readonly IOrderReadRepository _readRepository;

    public GetOrderByIdHandler(IOrderReadRepository readRepository)
    {
        _readRepository = readRepository;
    }

    public async Task<OrderDto> Handle(GetOrderByIdQuery request, CancellationToken cancellationToken)
    {
        return await _readRepository.GetByIdAsync(request.OrderId);
    }
}
