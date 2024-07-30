using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates;
using PlannetServer.Core.Aggregates.Communities;
using PlannetServer.Core.Aggregates.InfoCompany;
using PlannetServer.Core.Aggregates.Users;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(c => c.Id).HasConversion(
            userId => userId.Value,
            value => new UserId(value));

            //builder.Property(c => c.InfoCompanyId).HasConversion(
            //    infoCompanyId => infoCompanyId.Value,
            //    value => new InfoCompanyId(value));

        }
    }
}
