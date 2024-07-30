using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlannetServer.Application.Queries.Posts;
using PlannetServer.Shared.DTOs.Post;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PlannetServer.Api.Controllers
{
    public class PostsController : BaseController
    {
        public PostsController(IMediator mediator)
            : base(mediator) { }


        /// <summary>
        /// Returns a list of orders.
        /// </summary>
        /// <response code="200">Returns a list containing all orders.</response>
        /// <response code="400">The HTTP `400 [Bad Request]` response code indicates that the server cannot or will not process the request due to something that is perceived to be a client error.</response>
        /// <response code="404">The HTTP `404 [Not Found]` response code indicates that the server can not find the requested resource.</response>
        [ProducesResponseType(typeof(IEnumerable<PostDto>), StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get([FromRoute] GetPostQuery query)
            => Select(await Mediator.Send(query));
    }
}
