using System;

namespace PlannetServer.Application.Dtos.Company;

public class CreatePromotionDto
{
    public required string Description { get; set; }
    public required int Goal { get; set; }
    public required DateTimeOffset Deadline { get; set; }
}
