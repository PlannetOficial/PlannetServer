using PlannetServer.Core.Relations;
using PlannetServer.Shared.Kernel.BuildingBlocks;
using System;

namespace PlannetServer.Core.Aggregates.Categories
{
    public class Category : AggregateRoot
    {
        public CategoryId Id { get; private set; }
        public string Description { get; private set; }
        public string ImgUrl { get; private set; }
        public string Name { get; private set; }

        private Category() { }

        public ICollection<PostCategoryRelation> PostCategoryRelations { get; private set; } = new List<PostCategoryRelation>();


        public Category(CategoryId id, string description, string imgUrl, string name)
        {
            Id = id ?? throw new ArgumentNullException(nameof(id));
            Description = description ?? throw new ArgumentNullException(nameof(description));
            ImgUrl = imgUrl ?? throw new ArgumentNullException(nameof(imgUrl));
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription ?? throw new ArgumentNullException(nameof(newDescription));
        }

        public void UpdateImgUrl(string newImgUrl)
        {
            ImgUrl = newImgUrl ?? throw new ArgumentNullException(nameof(newImgUrl));
        }

        public void UpdateName(string newName)
        {
            Name = newName ?? throw new ArgumentNullException(nameof(newName));
        }
    }
}
