using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Promotions
{
    public class Promotion : AggregateRoot
    {
        public PromotionId Id { get; private set; }
        public DateTimeOffset Deadline { get; private set; }
        public string Description { get; private set; }
        public int Goal { get; private set; }

        private Promotion() { }

        public Promotion(PromotionId id, DateTimeOffset deadline, string description, int goal)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Deadline = deadline;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            Goal = goal;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription ?? throw new ArgumentNullException(nameof(newDescription));
        }

        public void UpdateDeadline(DateTimeOffset newDeadline)
        {
            Deadline = newDeadline;
        }
    }
}
