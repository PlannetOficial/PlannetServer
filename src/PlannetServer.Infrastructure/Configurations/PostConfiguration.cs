using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PlannetServer.Core.Aggregates.Communities;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Core.Aggregates.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace PlannetServer.Infrastructure.Configurations
{
    internal class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Location).HasColumnType("geography");

            builder.Property(c => c.Id).HasConversion(
            postId => postId.Value,
            value => new PostId(value));

            builder.Property(c => c.CommunityId).HasConversion(
                communityId => communityId.Value,
                value => new CommunityId(value));

            builder.Property(c => c.UserId)
                   .HasConversion(
                       userId => userId.Value,
                       value => new UserId(value))
                   .HasColumnType("uniqueidentifier");  // Make sure the database type is correctly defined if not using the default.


            builder.Property(c => c.HostCompanyId).HasConversion(
            hostCompanyId => hostCompanyId.Value,
            value => new UserId(value));

            builder
                .HasMany(p => p.PostCategoryRelations)
                .WithOne(pcr => pcr.Post)
                .HasForeignKey(pcr => pcr.PostId);

            builder
                .HasMany(p => p.PostUserRelations)
                .WithOne(pur => pur.Post)
                .HasForeignKey(pur => pur.PostId);



        }
    }
}
