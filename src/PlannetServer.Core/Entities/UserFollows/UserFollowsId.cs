using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Entities.UserFollows
{
    public sealed class UserFollowsId : TypedIdValueBase<long>
    {
        public UserFollowsId() { }
        public UserFollowsId(long value)
            : base(value) { }

        public static implicit operator UserFollowsId(long userFollowsId)
            => new UserFollowsId(userFollowsId);
    }
}
