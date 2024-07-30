namespace PlannetServer.Application.Dtos.Company;

public class InfoCompanyDto
{
    public required long InfoCompanyId { get; set; }
    public required string Direction { get; set; }
    public required string VAT { get; set; }
    public PromotionDto? Promotion { get; set; }
}
