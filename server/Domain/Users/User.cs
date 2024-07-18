
using Domain.Primitives;
using Domain.Users.Events;

namespace Domain.Users
{
    public sealed class User : Entity<Guid>
    {

        private User(Guid id,Username username, string fullName,string profilePictureUrl) : base(id)
        {
            Username = username;
            FullName = fullName;
            ProfilePictureURL = profilePictureUrl;
        }

        public Username? Username { get;private set; }

        public string? FullName { get; private set; }

        public string? ProfilePictureURL { get; private set; }

        public static User Create(string username, string fullName, string profilePictureUrl)
        {
            var user = new User(Guid.NewGuid(),new Username(username),fullName,profilePictureUrl);

            user.RaiseDomainEvent(new UserRegisteredDomainEvent(user.Id));

            return user;
        }

    }
}
