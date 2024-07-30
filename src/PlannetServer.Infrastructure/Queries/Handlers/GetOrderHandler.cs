using MediatR;
using PlannetServer.Core.Repositories;

namespace PlannetServer.Infrastructure.Queries.Handlers
{
    //public class GetOrderHandler : IRequestHandler<GetOrder, OrderDto>
    //{
    //    private readonly IOrdersRepository _repository;

    //    public GetOrderHandler(IOrdersRepository repository)
    //        => _repository = repository;

    //    public async Task<OrderDto> Handle(GetOrder query, CancellationToken cancellationToken)
    //        => (await _repository.GetAsync(query.Id))
    //            ?.AsDto();
    //}
}
