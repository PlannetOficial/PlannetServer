using PlannetServer.Core.Aggregates.Users;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core.Entities.UserFollows
{
    public class UserFollows : IEntity<UserFollowsId,long>
    {
        public UserFollowsId Id { get; private set; }
        public UserId FollowerId { get; private set; }
        public UserId FollowedId { get; private set; }

        private UserFollows() { }

        public UserFollows(UserFollowsId id, UserId followerId, UserId followedId)
        {
            Id = id;
            FollowerId = followerId;
            FollowedId = followedId;
        }
    }
}
