
using PlannetServer.Application.Dtos.Company;

namespace PlannetServer.Application.DTOs.Users;

public class UserDto
{
    public required string Id { get; set; }
    public required string Username { get; set; }
    public required ICollection<string> FollowersIds { get; set; }
    public required ICollection<string> FollowedIds { get; set; }
    public required string FullName { get; set; }
    public required string PictureUrl { get; set; }
    public string? NotificationToken { get; set; }
    public InfoCompanyDto? InfoCompany { get; set; }
}
