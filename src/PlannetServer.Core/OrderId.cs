using System;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core
{
    public sealed class OrderId : TypedIdValueBase<Guid>
    {
        public OrderId(Guid value)
            : base(value) { }

        public static implicit operator OrderId(Guid orderId)
            => new OrderId(orderId);

        public static implicit operator Guid(OrderId v)
        {
            throw new NotImplementedException();
        }
    }
}
