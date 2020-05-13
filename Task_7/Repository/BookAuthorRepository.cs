using Task_7.DbConfiguration;
using Task_7.Interfaces;
using Task_7.Models;

namespace Task_7.Repository
{
    public class BookAuthorRepository : RepositoryBase<BookAuthor>, IBookAuthorRepository
    {
        public BookAuthorRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
