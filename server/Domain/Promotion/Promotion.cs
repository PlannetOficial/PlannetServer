using Domain.Primitives;

namespace Domain.Promotions
{
    public sealed class Promotion : Entity<Guid>
    {
        private Promotion(Guid id, string title, string description, DateTime startDate, DateTime endDate) : base(id)
        {
            Title = title;
            Description = description;
            StartDate = startDate;
            EndDate = endDate;
        }

        public string Title { get; private set; }

        public string Description { get; private set; }

        public DateTime StartDate { get; private set; }

        public DateTime EndDate { get; private set; }

        public static Promotion Create(string title, string description, DateTime startDate, DateTime endDate)
        {
            return new Promotion(Guid.NewGuid(), title, description, startDate, endDate);
        }
    }
}
