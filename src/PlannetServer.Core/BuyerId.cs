using System;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core
{
    public class BuyerId : TypedIdValueBase<Guid>
    {
        public BuyerId(Guid value)
            : base(value) { }

        public static implicit operator BuyerId(Guid buyerId)
            => new BuyerId(buyerId);
    }
}
