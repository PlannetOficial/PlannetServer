namespace PlannetServer.Application.Dtos.Company;

public class InsertCompanyDto
{
    public required string CompanyName { get; set; }
    public required string Direction { get; set; }
    public required string VAT { get; set; }
}
