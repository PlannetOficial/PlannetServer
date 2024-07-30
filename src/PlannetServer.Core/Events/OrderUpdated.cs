using PlannetServer.Core.Aggregates;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core.Events
{
    public class OrderUpdated : IDomainEvent
    {
        public Order Order { get; }

        public OrderUpdated(Order order)
            => Order = order;
    }
}
