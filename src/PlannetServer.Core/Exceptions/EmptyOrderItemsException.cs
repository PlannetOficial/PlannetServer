using System;
using PlannetServer.Shared.Exceptions;

namespace PlannetServer.Core.Exceptions
{
    public class EmptyOrderItemsException : DomainException
    {
        public Guid OrderId { get; }

        public EmptyOrderItemsException(Guid orderId)
            : base($"Empty order items defined for order with ID: {orderId}")
                => OrderId = orderId;
    }
}
