using MediatR;
using PlannetServer.Shared.DTOs.Post;
using PlannetServer.Application.Queries.Posts;
using PlannetServer.Core.Repositories;
using AutoMapper;
using Microsoft.Extensions.Logging;

namespace PlannetServer.Application.Queries.Handlers
{
    public class GetPostsHandler : IRequestHandler<GetPostQuery, IEnumerable<PostDto>>
    {
        private readonly IPostsRepository _postsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<GetPostsHandler> _logger;

        public GetPostsHandler(IMapper mapper, IPostsRepository postsRepository)
        {
            _mapper = mapper;
            _postsRepository = postsRepository;
        }

        public async Task<IEnumerable<PostDto>> Handle(GetPostQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var posts = await _postsRepository.BrowseAsync();
                var postsDto = _mapper.Map<ICollection<PostDto>>(posts).ToList();
                return postsDto;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An error occurred while handling GetPostQuery");
                throw new ApplicationException("An error occurred while retrieving posts", ex);
            }

        }
    }
}
