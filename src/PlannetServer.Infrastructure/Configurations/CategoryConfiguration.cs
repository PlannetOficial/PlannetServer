using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates.Categories;
using PlannetServer.Core.Aggregates.Communities;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id).HasConversion(
            categoryId => categoryId.Value,
            value => new CategoryId(value));
        }
    }
}
