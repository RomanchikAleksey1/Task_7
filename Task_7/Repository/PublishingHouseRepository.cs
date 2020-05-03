using Task_7.DbConfiguration;
using Task_7.Interfaces;
using Task_7.Models;

namespace Task_7.Repository
{
    public class PublishingHouseRepository : RepositoryBase<PublishingHouse>, IPublishingHouseRepository
    {
        public PublishingHouseRepository(AppDbContext dbContext) : base(dbContext)
        {
        }
    }
}
