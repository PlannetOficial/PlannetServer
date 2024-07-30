using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Communities
{
    public class CommunityId : TypedIdValueBase<long>
    {
        public CommunityId() { }
        public CommunityId(long value)
            : base(value) { }

        public static implicit operator CommunityId(long communityId)
            => new CommunityId(communityId);
    }
}
