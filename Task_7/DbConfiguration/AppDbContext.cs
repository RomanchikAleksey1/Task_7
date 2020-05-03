using Microsoft.EntityFrameworkCore;
using Task_7.DbConfiguration.Configuration;

namespace Task_7.DbConfiguration
{
    public sealed class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options): base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookAuthorConfiguration());
            builder.ApplyConfiguration(new PublishingHouseConfiguration());
        }

    }
}
