using Domain.Primitives;

namespace Domain.Communities
{
    public sealed class Community : Entity<Guid>
    {
        private Community(Guid id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public static Community Create(string name, string description)
        {
            return new Community(Guid.NewGuid(), name, description);
        }
    }
}
