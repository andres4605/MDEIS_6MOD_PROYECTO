using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Ordering.Application.Commands.CreateOrder;

public record CreateOrderCommand(Guid OrderId, List<Guid> ProductIds) : IRequest<bool>;
