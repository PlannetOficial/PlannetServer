using System;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core
{
    public sealed class OrderItemId : TypedIdValueBase<Guid>
    {
        public OrderItemId(Guid value)
            : base(value) { }

        public static implicit operator OrderItemId(Guid orderItemId)
            => new OrderItemId(orderItemId);
    }
}
