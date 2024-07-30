using System;

namespace PlannetServer.Shared.Exceptions
{
    public class InvalidTypedIdException<T> : DomainException
    {
        public override string Code => "invalid_typed_id";
        public T Id { get; }
        public InvalidTypedIdException(T id)
            : base($"Invalid typed ID: '{id}'. Id value cannot be null or empty!")
                => Id = id;
    }
}
