//using System;
//using System.Threading;
//using System.Threading.Tasks;
//using AutoMapper;
//using MediatR;
//using Microsoft.Extensions.Logging;
//using PlannetServer.Application.Exceptions;
//using PlannetServer.Application.Commands.WriteModels;
//using PlannetServer.Core.Aggregates.Posts;
//using PlannetServer.Core.Repositories;
//using PlannetServer.Core.Aggregates.Categories;
//using PlannetServer.Core.Aggregates.Communities;
//using PlannetServer.Core.Aggregates.Users;
//using PlannetServer.Core.Entities.PostCategoryRelation;
//using PlannetServer.Application.Commands.Posts.Create;

//namespace PlannetServer.Application.Commands.Handlers
//{
//    public class CreatePostHandler : IRequestHandler<CreatePost>
//    {
//        private readonly IPostsRepository _postsRepository;
//        private readonly IMapper _mapper;
//        private readonly ILogger<CreatePostHandler> _logger;

//        public CreatePostHandler(IPostsRepository postsRepository, IMapper mapper, ILogger<CreatePostHandler> logger)
//        {
//            _postsRepository = postsRepository;
//            _mapper = mapper;
//            _logger = logger;
//        }

//        public async Task<Unit> Handle(CreatePost command, CancellationToken cancellationToken)
//        {
//            var postExists = await _postsRepository.GetAsync(command.Id);

//            //if (postExists is not null)
//            //{
//            //    throw new PostAlreadyExistsException(command.Id);
//            //}

//            var newPost = _mapper.Map<Post>(command.WriteModel);

//            foreach (var categoryDto in command.WriteModel.Categories)
//            {
//                var categoryRelation = new PostCategoryRelation(new PostCategoryRelationId(Guid.NewGuid()), newPost.Id, new CategoryId(categoryDto.Id));
//                newPost.AddCategory(categoryRelation);
//            }

//            await _postsRepository.AddAsync(newPost);

//            _logger.LogInformation($"Post with ID: {newPost.Id} has been created.");

//            return Unit.Value;
//        }
//    }
//}
