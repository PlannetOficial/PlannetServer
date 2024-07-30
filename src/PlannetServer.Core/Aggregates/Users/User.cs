using System;
using PlannetServer.Core.Aggregates.Users;
using PlannetServer.Core.Relations;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core.Aggregates
{
    public class User : AggregateRoot
    {
        public UserId Id { get; private set; }
        public string FullName { get; private set; }
        public long? InfoCompanyId { get; private set; }
        public string NotificationToken { get; private set; }
        public string PictureUrl { get; private set; }
        public string Username { get; private set; }

        public ICollection<PostUserRelation> PostUserRelations { get; private set; } = new List<PostUserRelation>();


        private User() { }

        public User(UserId id, string fullName, long? infoCompanyId, string notificationToken, string pictureUrl, string username)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
            InfoCompanyId = infoCompanyId;
            NotificationToken = notificationToken ?? throw new ArgumentNullException(nameof(notificationToken));
            PictureUrl = pictureUrl ?? throw new ArgumentNullException(nameof(pictureUrl));
            Username = username ?? throw new ArgumentNullException(nameof(username));
        }

        public void UpdateFullName(string newFullName)
        {
            FullName = newFullName ?? throw new ArgumentNullException(nameof(newFullName));
        }

        public void UpdatePictureUrl(string newPictureUrl)
        {
            PictureUrl = newPictureUrl ?? throw new ArgumentNullException(nameof(newPictureUrl));
        }
    }
}
