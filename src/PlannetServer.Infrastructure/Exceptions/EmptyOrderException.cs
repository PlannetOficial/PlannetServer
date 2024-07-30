using PlannetServer.Shared.Exceptions;

namespace PlannetServer.Infrastructure.Exceptions
{
    public class EmptyOrderException : InfrastructureException
    {
        public EmptyOrderException()
            : base($"Empty order defined.") { }
    }
}
