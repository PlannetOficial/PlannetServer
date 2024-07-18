using Domain.Primitives;
using System.Security.Cryptography.X509Certificates;

namespace Domain.Posts
{
    public sealed class Post : Entity<Guid>
    {
        private Post(Guid id, string title, Guid userId, string? description, string? image, DateTime creationDate, DateTime planDate, double? cost) : base(id)
        {
            Title = title;
            UserId = userId;
            Description = description;
            Image = image;
            CreationDate = creationDate;
            PlanDate = planDate;
            Cost = cost;
        }

        public string? Title { get; private set; }

        public Guid? UserId { get; private set; }

        public string? Description { get; private set; }

        public string? Image { get; private set; }

        public DateTime? CreationDate { get; private set; }

        public DateTime? PlanDate { get; private set; }

        public double? Cost { get; private set; }

        public static Post Create(Guid id, string title, Guid userId, string? description, string? image, DateTime creationDate, DateTime planDate, double? cost)
        {
            return new Post(id, title, userId, description, image, creationDate, planDate, cost);
        }


    }
}
