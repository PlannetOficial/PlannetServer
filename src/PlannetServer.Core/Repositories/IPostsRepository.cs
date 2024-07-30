using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Shared.DTOs.Post;

namespace PlannetServer.Core.Repositories
{
    public interface IPostsRepository
    {
        Task<Post> GetAsync(Guid id);
        Task<IEnumerable<Post>> BrowseAsync();
        Task AddAsync(Post post);
        Task UpdateAsync(Post post);
    }
}
