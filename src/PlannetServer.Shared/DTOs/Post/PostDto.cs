using PlannetServer.Application.DTOs.Category;
using PlannetServer.Application.DTOs.Community;
using PlannetServer.Application.DTOs.Users;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Shared.DTOs.Post;


public class PostDto
{
    public required Guid Id { get; set; }
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required string ImgUrl { get; set; }
    public required DateTimeOffset CreationDate { get; set; }
    public DateTimeOffset? PlanDate { get; set; }
    public required string UserId { get; set; }
    public UserDto? User { get; set; }
    public UserDto? HostCompany { get; set; }
    public ICollection<CategoryDto>? Categories { get; set; }
    public required ICollection<UserDto> Participants { get; set; } = new List<UserDto>();
    public string? Address { get; set; }
    public LocationDto? Location { get; set; }
    public Guid? CommunityId { get; set; }
    public CommunityDto? Community { get; set; }

    public decimal? Cost { get; set; }
    public int? MaxParticipants { get; set; }
    public int? AbilityLevel { get; set; }
    public bool? IsAccessible { get; set; }
    public string? NecessaryEquipment { get; set; }

    public required List<IDomainEvent> DomainEvents { get; set; }
}
