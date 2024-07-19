using Domain.Primitives;
using MediatR;

namespace Application.Interfaces
{
    public interface IQueryHander<TQuery, TResponse> : IRequestHandler<TQuery, Result<TResponse>>
        where TQuery : IQuery<TResponse>
    {

    }
}
