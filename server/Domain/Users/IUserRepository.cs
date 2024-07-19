namespace Domain.Users
{
    public interface IUserRepository
    {
        Task<User?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
        Task<User?> GetByUsernameAsync(string username, CancellationToken cancellationToken = default);

        Task AddAsync(User user, CancellationToken cancellationToken = default);
        Task<ICollection<User>> GetAllAsync(CancellationToken cancellationToken = default);

        Task<ICollection<User>> GetUsersByIdAsync(ICollection<Guid> ids, CancellationToken cancellationToken = default);
        Task<bool> UserExistsAsync(Guid id, CancellationToken cancellationToken = default);

        Task AddNotificationTokenAsync(User user, string notificationToken, CancellationToken cancellationToken = default);
        Task<ICollection<User>> GetFollowersAsync(Guid id, CancellationToken cancellationToken = default);
        Task<ICollection<User>> GetFollowingAsync(Guid id, CancellationToken cancellationToken = default);

        Task UnfollowUserAsync(Guid currentUserId, Guid followedUserId, CancellationToken cancellationToken = default);
        Task FollowUserAsync(Guid currentUserId, Guid followedUserId, CancellationToken cancellationToken = default);

        Task<User?> TryGetFullUserAsync(Guid id, CancellationToken cancellationToken = default);

        Task<User> InsertUserAsync(User user, CancellationToken cancellationToken = default);
        Task<User> UpdateUserAsync(User user, CancellationToken cancellationToken = default);

        Task DeleteUserAsync(Guid id, CancellationToken cancellationToken = default);

        //Task<(ICollection<User> posts, int count)> GetFilteredUsers(
        //    RepositoryFilteredRequest<User, string> filteredRequest
        //);
    }
}
