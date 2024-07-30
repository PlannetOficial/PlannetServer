using MediatR;
using Microsoft.EntityFrameworkCore;
using PlannetServer.Core.Aggregates;
using PlannetServer.Core.Aggregates.Posts;
using PlannetServer.Core.Relations;
using PlannetServer.Shared.Kernel.BuildingBlocks;

namespace PlannetServer.Infrastructure.Data
{
    public sealed class ApplicationDbContext : DbContext
    {
        private readonly IPublisher _publisher;

        public DbSet<User> User { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostCategoryRelation> PostCategoryRelation { get; set; }
        public DbSet<PostUserRelation> PostUserRelation { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options, IPublisher publisher) : base(options)
        {
            _publisher = publisher;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var result = await base.SaveChangesAsync(cancellationToken);
            await PublishDomainEventsAsync();
            return result;
        }

        private async Task PublishDomainEventsAsync()
        {
            var domainEvents = ChangeTracker
                .Entries<AggregateRoot>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .SelectMany(e =>
                {
                    var events = e.DomainEvents.ToList();
                    e.ClearEvents();
                    return events;
                })
                .ToList();

            foreach (var domainEvent in domainEvents)
            {
                await _publisher.Publish(domainEvent);
            }
        }
    }
}
