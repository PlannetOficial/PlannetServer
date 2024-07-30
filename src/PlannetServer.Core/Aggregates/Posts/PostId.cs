using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Posts
{
    public class PostId : TypedIdValueBase<Guid>
    {
        public PostId() { } 
        public PostId(Guid value)
            : base(value) { }

        public static implicit operator PostId(Guid userId)
            => new PostId(userId);
    }
}
