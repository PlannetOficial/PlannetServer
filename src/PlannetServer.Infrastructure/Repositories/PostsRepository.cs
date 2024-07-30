using Microsoft.EntityFrameworkCore;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Core.Repositories;
using PlannetServer.Infrastructure.Data;

namespace PlannetServer.Infrastructure.Repositories
{
    public class PostsRepository : IPostsRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PostsRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Post post)
        {
            await _dbContext.Post.AddAsync(post);
        }

        public async Task<IEnumerable<Post>> BrowseAsync()
        {
            return await JoinWithCategoryAndUser().ToListAsync();

            //return await _dbContext.Post.ToListAsync();
        }

        public async Task<Post> GetAsync(Guid id)
        {
            var post = await _dbContext.Post.FindAsync(id);
            return post ?? throw new KeyNotFoundException($"Post with id {id} not found.");
        }

        public async Task UpdateAsync(Post post)
        {
            _dbContext.Post.Update(post);
            await _dbContext.SaveChangesAsync();
        }

        private IQueryable<Post> JoinWithCategoryAndUser()
        {
            return _dbContext.Post
                .Include(p => p.PostCategoryRelations)
                .Include(p => p.PostUserRelations);
        }
    }   
}
