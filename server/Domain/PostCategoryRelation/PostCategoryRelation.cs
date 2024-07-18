using Domain.Primitives;

namespace Domain.Relations
{
    public sealed class PostCategoryRelation : Entity<Guid>
    {
        private PostCategoryRelation(Guid id, Guid postId, Guid categoryId) : base(id)
        {
            PostId = postId;
            CategoryId = categoryId;
        }

        public Guid PostId { get; private set; }

        public Guid CategoryId { get; private set; }

        public static PostCategoryRelation Create(Guid postId, Guid categoryId)
        {
            return new PostCategoryRelation(Guid.NewGuid(), postId, categoryId);
        }
    }
}
