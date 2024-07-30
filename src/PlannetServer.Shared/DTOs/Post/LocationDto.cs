namespace PlannetServer.Shared.DTOs.Post;

//IMPORTANT: The location when received is expected as the format of the Google API, which has Latitude and Longitude switched up,
//it is fixed in the mapping to the domain model
public class LocationDto
{
    public required double Latitude { get; set; }
    public required double Longitude { get; set; }
}
