using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Core.Relations;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class PostUserRelationConfiguration : IEntityTypeConfiguration<PostUserRelation>
    {
        public void Configure(EntityTypeBuilder<PostUserRelation> builder)
        {
            builder.HasKey(pur => new { pur.PostId, pur.UserId });


            builder
                .HasOne(pur => pur.Post)
                .WithMany(p => p.PostUserRelations)
                .HasForeignKey(pur => pur.PostId);

            builder
                .HasOne(pur => pur.User)
                .WithMany(u => u.PostUserRelations)
                .HasForeignKey(pur => pur.UserId);
        }
    }
}
