using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Users
{
    public class UserId : TypedIdValueBase<Guid>
    {
        public UserId() { }
        public UserId(Guid value)
            : base(value) { }

        public static implicit operator UserId(Guid userId)
            => new UserId(userId);
    }
}
