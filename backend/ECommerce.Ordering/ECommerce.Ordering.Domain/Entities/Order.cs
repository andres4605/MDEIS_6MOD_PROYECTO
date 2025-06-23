using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Ordering.Domain.Entities;

public class Order
{
    public Guid Id { get; private set; }
    public List<Guid> ProductIds { get; private set; }
    public decimal Total { get; private set; }

    public Order(Guid id, List<Guid> productIds)
    {
        Id = id;
        ProductIds = productIds;
        Total = CalculateTotal(productIds);
    }

    private decimal CalculateTotal(List<Guid> products)
    {
        return products.Count * 10.0m;
    }
}
