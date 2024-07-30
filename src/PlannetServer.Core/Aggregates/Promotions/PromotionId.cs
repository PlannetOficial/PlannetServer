using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Promotions
{
    public class PromotionId : TypedIdValueBase<long>
    {
        public PromotionId() { }
        public PromotionId(long value)
            : base(value) { }

        public static implicit operator PromotionId(long promotionId)
            => new PromotionId(promotionId);
    }
}
