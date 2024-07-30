using PlannetServer.Shared.Kernel.BuildingBlocks;
using PlannetServer.Core.Entities;

namespace PlannetServer.Core.Events
{
    public class OrderItemAdded : IDomainEvent
    {
        public OrderItem OrderItem { get; }

        public OrderItemAdded(OrderItem orderItem)
            => OrderItem = orderItem;
    }
}
