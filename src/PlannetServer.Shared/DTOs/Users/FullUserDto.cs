

using PlannetServer.Shared.Dtos.Commmunity;

namespace PlannetServer.Application.DTOs.Users;

public class FullUserDto : UserDto
{
    public required ICollection<CommunityAssignationDto> Communities { get; set; }
}
