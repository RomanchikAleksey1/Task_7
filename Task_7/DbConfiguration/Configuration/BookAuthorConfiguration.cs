using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Task_7.Models;

namespace Task_7.DbConfiguration.Configuration
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.ToTable("BookAuthor");
            builder.HasKey(x => new { x.BookId, x.AuthorId });

            builder.HasOne(x => x.Book)
                .WithMany(x => x.BookAuthors)
                .HasForeignKey(x => x.BookId);

            builder.HasOne(x => x.Author)
                .WithMany(x => x.BookAuthors)
                .HasForeignKey(x => x.AuthorId);
        }
    }
}
