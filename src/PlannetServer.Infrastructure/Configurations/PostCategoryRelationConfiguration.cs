using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Relations;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class PostCategoryRelationConfiguration : IEntityTypeConfiguration<PostCategoryRelation>
    {
        public void Configure(EntityTypeBuilder<PostCategoryRelation> builder)
        {
            builder.HasKey(pcr => new { pcr.PostId, pcr.CategoryId });

            builder
                .HasOne(pcr => pcr.Post)
                .WithMany(p => p.PostCategoryRelations)
                .HasForeignKey(pcr => pcr.PostId);

            builder
                .HasOne(pcr => pcr.Category)
                .WithMany(c => c.PostCategoryRelations)
                .HasForeignKey(pcr => pcr.CategoryId);
        }
    }
}
