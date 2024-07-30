using System.Net;

namespace PlannetServer.Shared.Exceptions
{
    public record ExceptionResponse(object Response, HttpStatusCode StatusCode);
}
