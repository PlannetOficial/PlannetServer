using Domain.Primitives;
using MediatR;

namespace Application.Interfaces
{
    public interface IQuery<TResponse> : IRequest<Result<TResponse>>
    {

    }
}
