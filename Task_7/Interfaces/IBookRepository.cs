using System.Linq;
using Task_7.Models;

namespace Task_7.Interfaces
{
    public interface IBookRepository : IRepositoryBase<Book>
    {
        IQueryable<Book> FindByPublishingHouse(string publishingHouse);
    }
}