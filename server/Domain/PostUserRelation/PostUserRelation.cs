using Domain.Primitives;

namespace Domain.Relations
{
    public sealed class PostUserRelation : Entity<Guid>
    {
        private PostUserRelation(Guid id, Guid postId, Guid userId, DateTime createdAt) : base(id)
        {
            PostId = postId;
            UserId = userId;
            CreatedAt = createdAt;
        }

        public Guid PostId { get; private set; }

        public Guid UserId { get; private set; }

        public DateTime CreatedAt { get; private set; }

        public static PostUserRelation Create(Guid postId, Guid userId)
        {
            return new PostUserRelation(Guid.NewGuid(), postId, userId, DateTime.UtcNow);
        }
    }
}
