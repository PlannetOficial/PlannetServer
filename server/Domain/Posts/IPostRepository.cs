namespace Domain.Posts
{
    public interface IPostRepository
    {
        Task<List<Post>> GetAllAsync(CancellationToken cancellationToken = default);
        Task<Post?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        void Add(Post post);
    }
}
