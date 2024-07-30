using System;

namespace PlannetServer.Shared.Exceptions
{
    public interface IExceptionCompositionRoot
    {
        ExceptionResponse Map(Exception exception);
    }
}
