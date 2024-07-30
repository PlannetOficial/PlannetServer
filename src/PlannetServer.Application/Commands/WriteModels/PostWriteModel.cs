//using PlannetServer.Application.DTOs.Category;
//using PlannetServer.Application.DTOs.Post;
//using PlannetServer.Core.Aggregates.Communities;
//using PlannetServer.Core.Aggregates.InfoCompany;
//using PlannetServer.Core.Aggregates.Users;

//namespace PlannetServer.Application.Commands.WriteModels
//{
//    public class PostWriteModel
//    {
//        public required string Title { get; set; }
//        public required string Description { get; set; }
//        public required string ImgUrl { get; set; }
//        public DateTimeOffset? PlanDate { get; set; }
//        public required UserId UserId { get; set; }
//        public required ICollection<CategoryDto> Categories { get; set; }
//        public string? Address { get; set; }
//        public LocationDto? Location { get; set; }
//        public decimal? Cost { get; set; }
//        public InfoCompanyId? HostCompanyId { get; set; }
//        public int? MaxParticipants { get; set; }
//        public int? AbilityLevel { get; set; }
//        public bool? IsAccessible { get; set; }
//        public string? NecessaryEquipment { get; set; }
//        public CommunityId? CommunityId { get; set; }
//    }
//}
