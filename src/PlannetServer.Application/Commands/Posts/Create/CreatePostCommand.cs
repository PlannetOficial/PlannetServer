//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using PlannetServer.Application.Commands.WriteModels;
//using PlannetServer.Core;
//using MediatR;

//namespace PlannetServer.Application.Commands.Posts.Create
//{
//    public record CreatePost([Required] PostWriteModel WriteModel) : IRequest
//    {
//        public Guid Id { get; init; } = Guid.NewGuid();
//    }
//}
