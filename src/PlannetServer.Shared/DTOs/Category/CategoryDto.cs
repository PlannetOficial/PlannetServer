namespace PlannetServer.Application.DTOs.Category
{
    public class CategoryDto
    {
        public required int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required string ImgUrl { get; set; }
    }

}
