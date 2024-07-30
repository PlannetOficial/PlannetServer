using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates.Communities;
using PlannetServer.Core.Aggregates.Posts;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class CommunityConfiguration : IEntityTypeConfiguration<Community>
    {
        public void Configure(EntityTypeBuilder<Community> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id).HasConversion(
            communityId => communityId.Value,
            value => new CommunityId(value));

        }
    }
}
