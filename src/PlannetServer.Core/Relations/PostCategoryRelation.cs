using PlannetServer.Core.Aggregates.Categories;
using PlannetServer.Core.Aggregates.Posts;

namespace PlannetServer.Core.Relations
{
    public class PostCategoryRelation
    {
        public required Guid PostId { get; set; }
        public required Post Post { get; set; }

        public required int CategoryId { get; set; }
        public required Category Category { get; set; }
    }
}
