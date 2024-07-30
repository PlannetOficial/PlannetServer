using PlannetServer.Core.Aggregates.Users;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Core.Aggregates.Communities
{
    public class Community : AggregateRoot
    {
        public CommunityId Id { get; private set; }
        public string ImgUrl { get; private set; }
        public string Name { get; private set; }

        private HashSet<UserId> _admins = new HashSet<UserId>();
        private HashSet<UserId> _members = new HashSet<UserId>();

        public IEnumerable<UserId> Admins => _admins;
        public IEnumerable<UserId> Members => _members;

        private Community() { }

        public Community(CommunityId id, string imgUrl, string name)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            ImgUrl = imgUrl ?? throw new ArgumentNullException(nameof(imgUrl));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void UpdateName(string newName)
        {
            Name = newName ?? throw new ArgumentNullException(nameof(newName));
        }

        public void UpdateImgUrl(string newImgUrl)
        {
            ImgUrl = newImgUrl ?? throw new ArgumentNullException(nameof(newImgUrl));
        }

        public void AddAdmin(UserId userId)
        {
            _admins.Add(userId ?? throw new ArgumentNullException(nameof(userId)));
        }

        public void RemoveAdmin(UserId userId)
        {
            _admins.Remove(userId ?? throw new ArgumentNullException(nameof(userId)));
        }

        public void AddMember(UserId userId)
        {
            if (!_members.Contains(userId))
            {
                _members.Add(userId ?? throw new ArgumentNullException(nameof(userId)));
            }
        }

        public void RemoveMember(UserId userId)
        {
            _members.Remove(userId ?? throw new ArgumentNullException(nameof(userId)));
        }
    }
}
