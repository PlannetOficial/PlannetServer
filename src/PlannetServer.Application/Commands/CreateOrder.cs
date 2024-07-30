using MediatR;
using PlannetServer.Application.Commands.WriteModels;
using PlannetServer.Core;
using System.ComponentModel.DataAnnotations;

namespace PlannetServer.Application.Commands
{
    public record CreateOrder([Required] Guid BuyerId, [Required] AddressWriteModel ShippingAddress, [Required] IEnumerable<OrderItemWriteModel> Items) : IRequest
    {
        public Guid Id { get; init; } = new OrderId(Guid.NewGuid());
    }
}
