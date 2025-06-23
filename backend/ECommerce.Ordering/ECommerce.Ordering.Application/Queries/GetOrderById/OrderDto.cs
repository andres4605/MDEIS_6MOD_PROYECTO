namespace ECommerce.Ordering.Application.Queries.GetOrderById;

public class OrderDto
{
    public Guid Id { get; set; }
    public decimal Total { get; set; }
    public List<Guid> ProductIds { get; set; } = new();
}
