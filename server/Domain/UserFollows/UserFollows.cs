using Domain.Primitives;

namespace Domain.Relations
{
    public sealed class UserFollows : Entity<Guid>
    {
        private UserFollows(Guid id, Guid followerId, Guid followedId, DateTime followedAt) : base(id)
        {
            FollowerId = followerId;
            FollowedId = followedId;
            FollowedAt = followedAt;
        }

        public Guid FollowerId { get; private set; }

        public Guid FollowedId { get; private set; }

        public DateTime FollowedAt { get; private set; }

        public static UserFollows Create(Guid followerId, Guid followedId)
        {
            return new UserFollows(Guid.NewGuid(), followerId, followedId, DateTime.UtcNow);
        }
    }
}
