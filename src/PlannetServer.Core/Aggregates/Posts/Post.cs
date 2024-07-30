using PlannetServer.Core.Aggregates.Categories;
using PlannetServer.Core.Aggregates.Communities;
using PlannetServer.Core.Aggregates.Users;
using PlannetServer.Shared.Kernel.BuildingBlocks;
using System.ComponentModel.DataAnnotations.Schema;
using NetTopologySuite.Geometries;
using PlannetServer.Core.Relations;

namespace PlannetServer.Core.Aggregates.Posts
{
    public class Post : AggregateRoot
    {
        private HashSet<CategoryId> _categories = new HashSet<CategoryId>();
        private HashSet<UserId> _participants = new HashSet<UserId>();

        public PostId Id { get; private set; }
        public int? AbilityLevel { get; private set; }
        public string Address { get; private set; }
        public CommunityId? CommunityId { get; private set; }
        public decimal? Cost { get; private set; }
        public DateTimeOffset CreationDate { get; private set; }
        public string Description { get; private set; }
        public int GroupLimit { get; private set; }
        public UserId? HostCompanyId { get; private set; }
        public string ImgUrl { get; private set; }
        public bool IsAccessible { get; private set; }
        public Point Location { get; private set; }
        public int? MaxParticipants { get; private set; }
        public string NecessaryEquipment { get; private set; }
        public DateTimeOffset? PlanDate { get; private set; }
        public string Title { get; private set; }
        public UserId UserId { get; private set; }

        public ICollection<PostUserRelation> PostUserRelations { get; private set; } = new List<PostUserRelation>();
        public ICollection<PostCategoryRelation> PostCategoryRelations { get; private set; } = new List<PostCategoryRelation>();


        [NotMapped]
        public IEnumerable<CategoryId> Categories => _categories;

        [NotMapped]
        public IEnumerable<UserId> Participants => _participants;

        // Constructor privado usado por EF Core y otros ORMs
        private Post() { }

        // Constructor público para crear un nuevo Post
        public Post(PostId id, int? abilityLevel, string address, CommunityId? communityId, decimal? cost, DateTimeOffset creationDate, string description, int groupLimit, UserId hostCompanyId, string imgUrl, bool isAccessible, Point location, int? maxParticipants, string necessaryEquipment, DateTimeOffset? planDate, string title, UserId userId)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            AbilityLevel = abilityLevel;
            Address = address ?? throw new ArgumentNullException(nameof(address));
            CommunityId = communityId;
            Cost = cost;
            CreationDate = creationDate;
            Description = description ?? throw new ArgumentNullException(nameof(description));
            GroupLimit = groupLimit;
            HostCompanyId = hostCompanyId ?? throw new ArgumentNullException(nameof(hostCompanyId));
            ImgUrl = imgUrl ?? throw new ArgumentNullException(nameof(imgUrl));
            IsAccessible = isAccessible;
            Location = location ?? throw new ArgumentNullException(nameof(location));
            MaxParticipants = maxParticipants;
            NecessaryEquipment = necessaryEquipment ?? throw new ArgumentNullException(nameof(necessaryEquipment));
            PlanDate = planDate;
            Title = title ?? throw new ArgumentNullException(nameof(title));
            UserId = userId ?? throw new ArgumentNullException(nameof(userId));
        }

        public void AddCategory(CategoryId categoryId)
        {
            _categories.Add(categoryId ?? throw new ArgumentNullException(nameof(categoryId)));
        }

        public void RemoveCategory(CategoryId categoryId)
        {
            _categories.Remove(categoryId ?? throw new ArgumentNullException(nameof(categoryId)));
        }

        public void AddParticipant(UserId userId)
        {
            _participants.Add(userId ?? throw new ArgumentNullException(nameof(userId)));
        }

        public void RemoveParticipant(UserId userId)
        {
            _participants.Remove(userId ?? throw new ArgumentNullException(nameof(userId)));
        }
    }
}
