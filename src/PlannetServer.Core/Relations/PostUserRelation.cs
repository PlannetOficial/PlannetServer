using PlannetServer.Core.Aggregates;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Core.Aggregates.Users;

namespace PlannetServer.Core.Relations
{
    public class PostUserRelation
    {
        public required PostId PostId { get; set; }
        public required Post Post { get; set; }

        public required UserId UserId { get; set; }
        public required User User { get; set; }
    }
}
