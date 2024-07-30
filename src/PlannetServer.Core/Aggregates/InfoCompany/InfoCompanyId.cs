using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.InfoCompany
{
    public class InfoCompanyId : TypedIdValueBase<long>
    {
        public InfoCompanyId() { }
        public InfoCompanyId(long value)
            : base(value) { }

        public static implicit operator InfoCompanyId(long infoCompanyId)
            => new(infoCompanyId);
    }
}
