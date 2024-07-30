using System;
using ApplicationException = PlannetServer.Shared.Exceptions.ApplicationException;

namespace PlannetServer.Application.Exceptions
{
    public class OrderAlreadyExistsException : ApplicationException
    {
        public Guid OrderId { get; }

        public OrderAlreadyExistsException(Guid orderId)
            : base($"Order with Id: {orderId} already exists.")
                => OrderId = orderId;
    }
}
