using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates.Communities;
using PlannetServer.Core.Aggregates.Promotions;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        { 
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id).HasConversion(
            promotionId => promotionId.Value,
            value => new PromotionId(value));

        }
    }
}
