using AutoMapper;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Shared.DTOs.Post;
using NetTopologySuite.Geometries;
using PlannetServer.Application.DTOs.Category;
using PlannetServer.Core.Aggregates.Categories;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Post, PostDto>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id.Value))
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.UserId.Value))
            .ForMember(dest => dest.CommunityId, opt => opt.MapFrom(src => src.CommunityId != null ? src.CommunityId.Value : (long?)null))
            .ForMember(dest => dest.HostCompany, opt => opt.MapFrom(src => src.HostCompanyId != null ? src.HostCompanyId.Value : (Guid?)null)).ReverseMap();

        CreateMap<Point, LocationDto>()
        .ForMember(dest => dest.Longitude, opt => opt.MapFrom(src => src.Coordinate.X))
        .ForMember(dest => dest.Latitude, opt => opt.MapFrom(src => src.Coordinate.Y));

        CreateMap<Category, CategoryDto>().ForMember(dest=> dest.Id,opt => opt.MapFrom(src=> src.Id.Value)).ReverseMap();

        CreateMap<LocationDto, Point>().ConvertUsing<LocationConverter>();
        // Configuraciones adicionales según sea necesario
    }

    public class LocationConverter : ITypeConverter<LocationDto?, Point>
    {
        public Point Convert(LocationDto? source, Point destination, ResolutionContext context)
        {
            if (source == null)
            {
                return null!;
            }
            // Google API  formaat has the Longitude and Latitude switched up
            return new Point(source.Longitude, source.Latitude) { SRID = 4326 };
        }
    }
}
