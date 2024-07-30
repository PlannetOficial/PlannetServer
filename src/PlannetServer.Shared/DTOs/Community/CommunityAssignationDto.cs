using PlannetServer.Application.DTOs.Community;
using PlannetServer.Shared.Types;

namespace PlannetServer.Shared.Dtos.Commmunity;


public class CommunityAssignationDto
{
    public required CommunityDto Community { get; set; }
    public required UserCommunityRelationType Role { get; set; }
}
