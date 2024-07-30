using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.InfoCompany
{
    public class InfoCompany : AggregateRoot
    {
        public InfoCompanyId Id { get; private set; }
        public string FullName { get; private set; }
        public string Direction { get; private set; }
        public long? PromotionId { get; private set; }
        public string VAT { get; private set; }

        private InfoCompany() { }

        public InfoCompany(InfoCompanyId id, string fullName, string direction, long? promotionId, string vat)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            Direction = direction ?? throw new ArgumentNullException(nameof(direction));
            PromotionId = promotionId;
            VAT = vat ?? throw new ArgumentNullException(nameof(vat));
        }

        public void UpdateFullName(string newFullName)
        {
            FullName = newFullName ?? throw new ArgumentNullException(nameof(newFullName));
        }

        public void UpdateDirection(string newDirection)
        {
            Direction = newDirection ?? throw new ArgumentNullException(nameof(newDirection));
        }
    }
}
