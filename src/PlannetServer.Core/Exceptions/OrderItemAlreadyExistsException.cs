using System;
using PlannetServer.Shared.Exceptions;

namespace PlannetServer.Core.Exceptions
{
    public class OrderItemAlreadyExistsException : DomainException
    {
        public Guid OrderItemId { get; }

        public OrderItemAlreadyExistsException(Guid orderItemId)
            : base($"Order item with ID: {orderItemId} already exists.")
                => OrderItemId = orderItemId;
    }
}
