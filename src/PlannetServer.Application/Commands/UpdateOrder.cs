using System;
using System.Collections.Generic;
using PlannetServer.Application.Commands.WriteModels;
using MediatR;

namespace PlannetServer.Application.Commands
{
    public record UpdateOrder(Guid Id, Guid BuyerId, AddressWriteModel ShippingAddress, IEnumerable<OrderItemWriteModel> Items, string Status) : IRequest;
}
