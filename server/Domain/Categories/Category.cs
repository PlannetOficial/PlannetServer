using Domain.Primitives;

namespace Domain.Categories
{
    public sealed class Category : Entity<Guid>
    {
        private Category(Guid id, string name, string description) : base(id)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public static Category Create(string name, string description)
        {
            return new Category(Guid.NewGuid(), name, description);
        }
    }
}
