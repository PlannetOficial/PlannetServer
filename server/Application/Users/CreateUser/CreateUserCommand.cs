using Application.Interfaces;
using MediatR;

namespace Application.Users.CreateUser
{
    public record CreateUserCommand(string username) : ICommand<Unit>
    {

    }
}
