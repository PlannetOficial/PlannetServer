using Domain.Primitives;

namespace Domain.Relations
{
    public sealed class UserCommunityRelation : Entity<Guid>
    {
        private UserCommunityRelation(Guid id, Guid userId, Guid communityId) : base(id)
        {
            UserId = userId;
            CommunityId = communityId;
        }

        public Guid UserId { get; private set; }

        public Guid CommunityId { get; private set; }

        public static UserCommunityRelation Create(Guid userId, Guid communityId)
        {
            return new UserCommunityRelation(Guid.NewGuid(), userId, communityId);
        }
    }
}
