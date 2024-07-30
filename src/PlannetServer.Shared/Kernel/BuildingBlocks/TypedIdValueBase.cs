    using PlannetServer.Shared.Exceptions;

    namespace PlannetServer.Shared.Kernel.BuildingBlocks
    {
        public class TypedIdValueBase<T> : IEquatable<TypedIdValueBase<T>> where T : IEquatable<T>
        {
            public T Value { get; }

            protected TypedIdValueBase() { }
            protected TypedIdValueBase(T value)
            {
                if (value.Equals(default(T))) 
                {
                    throw new InvalidTypedIdException<T>(value);
                }

                Value = value;
            }

            public bool Equals(TypedIdValueBase<T> other)
            {
                if (ReferenceEquals(null, other)) return false;
                return ReferenceEquals(this, other) || Value.Equals(other.Value);
            }

            public override bool Equals(object obj)
            {
                if (ReferenceEquals(null, obj)) return false;
                if (ReferenceEquals(this, obj)) return true;
                return obj.GetType() == GetType() && Equals((TypedIdValueBase<T>)obj);
            }

            public override int GetHashCode()
                => Value.GetHashCode();

            public static bool operator ==(TypedIdValueBase<T> obj1, TypedIdValueBase<T> obj2)
            {
                if (object.Equals(obj1, null))
                {
                    return object.Equals(obj2, null);
                }
                return obj1.Equals(obj2);
            }

            public static bool operator !=(TypedIdValueBase<T> a, TypedIdValueBase<T> b)
                => !(a == b);

            public override string ToString() => Value.ToString();
        }
    }
