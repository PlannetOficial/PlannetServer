using Domain.Primitives;
using MediatR;

namespace Domain.Users.Events
{
    internal class UserRegisteredDomainEvent(Guid userId):IDomainEvent
    {

    }
}
