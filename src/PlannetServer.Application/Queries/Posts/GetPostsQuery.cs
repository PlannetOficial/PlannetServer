using MediatR;
using PlannetServer.Shared.DTOs.Post;

namespace PlannetServer.Application.Queries.Posts
{
    public class GetPostQuery : IRequest<IEnumerable<PostDto>>
    {

        public GetPostQuery()
        {
        }
    }
}
