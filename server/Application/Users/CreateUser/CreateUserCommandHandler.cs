using Application.Interfaces;
using Domain.Primitives;
using MediatR;

namespace Application.Users.CreateUser
{
    internal sealed class CreateUserCommandHandler : ICommandHandler<CreateUserCommand, Unit>
    {
        public Task<Result<Unit>> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
