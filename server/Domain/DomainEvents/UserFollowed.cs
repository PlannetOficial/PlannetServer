using Domain.Primitives;

namespace Domain.DomainEvents
{
    public sealed record UserFollowed(string currentUserId,string followedUserId) : IDomainEvent
    {

    }
}
